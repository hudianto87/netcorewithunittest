using Int.Api.Victoria.BusinessLayer.BindingModel;
using Int.Api.Victoria.BusinessLayer.BindingModelResult;
using Int.Api.Victoria.BusinessLayer.BusinessObject.Master;
using Int.Api.Victoria.BusinessLayer.Interface;
using Int.Api.Victoria.DataAccess.Context;
using Int.Api.Victoria.DataAccess.Models;
using Newtonsoft.Json;

namespace Int.Api.Victoria.BusinessLayer.BusinessObject
{
    public class BOProtectTransactions : IBOProtectTransactions
    {
        private readonly DBContext dbContext;
        private readonly Reference boReference;
        private readonly ResponseCode.ResponseCode responseCode;
        private readonly BOLogger boLogger;
        public BOProtectTransactions(DBContext dB)
        {
            dbContext = dB;
            boReference = new Reference(dbContext);
            responseCode = new();
            boLogger = new(dB);
        }
        public async Task<ResultBase<BMRProtectTransactions>> ProcessProtectTransactions(BMProtectTransactions request)
        {
            var result = new ResultBase<BMRProtectTransactions>
            {
                Data = new()
            };
            double QuotaProduct;
            string[] statusCustomer = new string[] { "OPEN", "ACTIVE" };
            try
            {
                #region Get And Validation Validation Request Get Data Channel and Config Key
                VTreferenceDetail? getDataChannel = await boReference.GetChannel(request.ChannelID.Trim());
                if (getDataChannel == null)
                {
                    result.IsOk = false;
                    result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS018);
                    result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS018.ToString();
                    return result;
                }

                Tconfig? tconfigTranFeeTaxValue = await boReference.GetConfigByKey("UI.Transaction.Fee.Tax.Value");
                if (tconfigTranFeeTaxValue == null)
                {
                    result.IsOk = false;
                    result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS072);
                    result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS072.ToString();
                    return result;
                }

                Tconfig? tconfigESBFeeTypeCode = await boReference.GetConfigByKey("ESB.FeeTypeCode");
                if (tconfigESBFeeTypeCode == null)
                {
                    result.IsOk = false;
                    result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS075);
                    result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS075.ToString();
                    return result;
                }
                #endregion

                #region Get And Validation Data Agent
                Tagent? dataAgent = await boReference.GetDataAgent(request.ChannelID.Trim());
                if (dataAgent is null)
                {
                    result.IsOk = false;
                    result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS054);
                    result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS054.ToString();
                    return result;
                }
                #endregion

                #region Get And Validation Request Get Data CIF
                Tcustomer? dataCustomer = await boReference.GetCustomerByCif(request.CIF.Trim());
                if (dataCustomer == null)
                {
                    result.IsOk = false;
                    result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS006);
                    result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS006.ToString();
                    return result;
                }

                bool flagStatusCustomer = statusCustomer.Contains(dataCustomer.Idstatus);
                if (!flagStatusCustomer)
                {
                    result.IsOk = false;
                    result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS091);
                    result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS091.ToString();
                    return result;
                }
                #endregion

                #region Get And Validation Data Product
                Tproduct? dataProduct = await boReference.GetProductByProductcode(request.ProductCode.Trim());
                if (dataProduct is null)
                {
                    result.IsOk = false;
                    result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS007);
                    result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS007.ToString();
                    return result;
                }

                if (!dataProduct.Idstatus)
                {
                    result.IsOk = false;
                    result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS088);
                    result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS088.ToString();
                    return result;
                }

                if (!dataProduct.Idmftype.Equals("CLOSE"))
                {
                    result.IsOk = false;
                    result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS089);
                    result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS089.ToString();
                    return result;
                }
                #endregion

                #region Calculation Quota and Validation Transaction SUB
                if (request.TransType.Equals("SUB"))
                {
                    TproductOfferingPeriod? dataOfferingProduct = await boReference.GetTproductOfferingPeriod(dataProduct.Idproduct);
                    if (dataOfferingProduct is null)
                    {
                        result.IsOk = false;
                        result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS090);
                        result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS090.ToString();
                        return result;
                    }

                    QuotaProduct = await boReference.GetQuotaCPF(dataProduct.Idproduct);
                    if (QuotaProduct is 0)
                    {
                        result.IsOk = false;
                        result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS092);
                        result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS092.ToString();
                        return result;
                    }

                    if (request.NetAmount == 0 || request.NetAmount < 0)
                    {
                        result.IsOk = false;
                        result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS095);
                        result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS095.ToString();
                        return result;
                    }

                    if (string.IsNullOrEmpty(request.HoldID.ToString()) || string.IsNullOrWhiteSpace(request.HoldID.ToString()))
                    {
                        result.IsOk = false;
                        result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS096);
                        result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS096.ToString();
                        return result;
                    }

                    if (QuotaProduct < request.NetAmount)
                    {
                        result.IsOk = false;
                        result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS093);
                        result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS093.ToString();
                        return result;
                    }
                }
                #endregion

                #region Validation Units and Transaction RED
                TsubAccount? dataSubAccount = new();
                Tnav? dataNAV = new();
                if (request.TransType.Equals("RED"))
                {
                    dataNAV = await boReference.GetDataNavByProduct(dataProduct.Idproduct);
                    if (dataNAV is null)
                    {
                        result.IsOk = false;
                        result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS081);
                        result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS081.ToString();
                        return result;
                    }

                    TproductExitWindow? dataExitWindow = await boReference.GetTproductExitWindow(dataProduct.Idproduct);
                    if (dataExitWindow is null)
                    {
                        result.IsOk = false;
                        result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS099);
                        result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS099.ToString();
                        return result;
                    }

                    dataSubAccount = await boReference.GetDataSubAccount(dataProduct.Idproduct, dataCustomer.Idcustomer);
                    if (dataSubAccount is null)
                    {
                        result.IsOk = false;
                        result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS098);
                        result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS098.ToString();
                        return result;
                    }

                    if (request.Units == 0 || request.Units < 0)
                    {
                        result.IsOk = false;
                        result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS097);
                        result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS097.ToString();
                        return result;
                    }
                }
                #endregion

                #region Get And Validation Customer Bank Account
                TcustBankAccount? dataBankAccount = await boReference.GetDataBankAccountCPF(dataCustomer.Idcustomer, dataProduct.Idcurrency, request.CustomerAccountNo);
                if (dataBankAccount is null)
                {
                    result.IsOk = false;
                    result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS013);
                    result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS013.ToString();
                    return result;
                }
                #endregion

                #region Get And Validation Product Bank Account
                TproductBankAccount? dataProductBankAccount = new();
                dataProductBankAccount = await boReference.GetDataProductBankAccount(dataProduct.Idproduct, dataProduct.Idcurrency, request.TransType.Trim());
                if (dataProductBankAccount is null)
                {
                    result.IsOk = false;
                    result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS094);
                    result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS094.ToString();
                    return result;
                }
                #endregion

                if (request.TransType.Equals("SUB"))
                {
                    #region Calculation Fee Amount
                    if (request.FeePercentage < 0)
                        request.FeePercentage = 0;
                    if (request.FeePercentage > 90)
                        request.FeePercentage = 90;

                    double resultFeeAmount = request.NetAmount / 100 * request.FeePercentage;
                    result.Data.Amount = request.NetAmount + request.Charges + resultFeeAmount;

                    //double resultFeeAmount = request.FeePercentage /= 100;
                    //request.FeeAmount = request.NetAmount * resultFeeAmount;

                    var insertDataSUB = new TtransactionBooking()
                    {
                        Idcategory = "SUB",
                        Idstatus = "ENTRIED",
                        ReferenceNo = request.RefNo,
                        Idcustomer = dataCustomer.Idcustomer,
                        Idproduct = dataProduct.Idproduct,
                        Idsales = dataAgent.AgentId,
                        Amount = result.Data.Amount,
                        Fee = request.FeePercentage,
                        FeeAmount = resultFeeAmount,
                        NetAmount = request.NetAmount,
                        Charges = request.Charges,
                        PaymentMethod = "TRS",
                        FeeMethod = "NETT",
                        CustAccountNo = dataBankAccount.AccountNo,
                        CustAccountName = dataBankAccount.AccountName,
                        CustIdcurrency = dataBankAccount.Idcurrency,
                        CustIdbankBranch = dataBankAccount.IdbankBranch,
                        ProdAccountNo = dataProductBankAccount.AccountNo,
                        ProdIdcurrency = dataProductBankAccount.Idcurrency,
                        ProdIdbankBranch = dataProductBankAccount.IdbankBranch,
                        SysCreatedBy = request.ChannelID.Trim(),
                        SysCreatedTime = DateTime.Now,
                        SysCreatedHost = request.ChannelID.Trim(),
                        SysActionType = "I",
                        SysApprovalStatus = 1,
                        SysRecStatus = true,
                        SysApprovedBy = request.ChannelID.Trim(),
                        SysApprovedTime = DateTime.Now,
                        SysApprovedHost = request.ChannelID.Trim(),
                        HoldId = request.HoldID,
                        IsWaiver = false
                    };
                    await dbContext.TtransactionBookings.AddAsync(insertDataSUB);
                    await dbContext.SaveChangesAsync();

                    result.Data.TransactionID = insertDataSUB.IdtransactionBooking;
                }

                if (request.TransType.Equals("RED"))
                {
                    double resultPercentage = request.Units / 100000;
                    resultPercentage *= 100.00;
                    resultPercentage = Math.Round(resultPercentage, 2);

                    double resultOutstandingUnit = await boReference.GetBalancePerSubAccount(dataSubAccount.IdsubAccount, DateTime.Now);
                    double resultOutstandingAmount = dataNAV.Value * resultOutstandingUnit;

                    var insertDataRED = new TtransactionBooking()
                    {
                        Idcategory = request.TransType.Trim(),
                        Idstatus = "ENTRIED",
                        ReferenceNo = request.RefNo,
                        IdsubAccount = dataSubAccount.IdsubAccount,
                        Idcustomer = dataCustomer.Idcustomer,
                        Idproduct = null,
                        Idsales = dataAgent.AgentId,
                        Navdate = dataNAV.Navdate,
                        OutstandingUnit = resultOutstandingUnit,
                        OutstandingAmount = resultOutstandingAmount,
                        Units = request.Units,
                        Amount = null,
                        Fee = 0,
                        FeeAmount = null,
                        NetAmount = null,
                        Charges = 0,
                        IsRedemAll = null,
                        PaymentMethod = "TRS",
                        FeeMethod = null,
                        InputMode = 1, // RedemptionBy / InputMode -- 1 BY UNIT
                        Percentage = resultPercentage,
                        CustAccountNo = dataBankAccount.AccountNo,
                        CustAccountName = dataBankAccount.AccountName,
                        CustIdcurrency = dataBankAccount.Idcurrency,
                        CustIdbankBranch = dataBankAccount.IdbankBranch,
                        ProdAccountNo = dataProductBankAccount.AccountNo,
                        ProdIdcurrency = dataProductBankAccount.Idcurrency,
                        ProdIdbankBranch = dataProductBankAccount.IdbankBranch,
                        SysCreatedBy = request.ChannelID.Trim(),
                        SysCreatedTime = DateTime.Now,
                        SysCreatedHost = request.ChannelID.Trim(),
                        SysActionType = "I",
                        SysApprovalStatus = 1,
                        SysRecStatus = true,
                        SysApprovedBy = request.ChannelID.Trim(),
                        SysApprovedTime = DateTime.Now,
                        SysApprovedHost = request.ChannelID.Trim(),
                        HoldId = null,
                        IsWaiver = false
                    };
                    await dbContext.TtransactionBookings.AddAsync(insertDataRED);
                    await dbContext.SaveChangesAsync();

                    result.Data.TransactionID = insertDataRED.IdtransactionBooking;
                    result.Data.Units = request.Units;
                }

                result.Data.ProductCode = dataProduct.ProductCode;
                result.Data.CustomerAccountNo = dataBankAccount.AccountNo;
                result.Data.CustomerAccountName = dataBankAccount.AccountName;
                result.Data.RefNo = request.RefNo;
                result.Data.CIF = request.CIF;
                #endregion
            }
            catch (Exception ex)
            {
                result.IsOk = false;
                result.Message = ex.Message;
                result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS999.ToString();
            }
            finally
            {
                await boLogger.SaveLog("IN", request.ChannelID.Trim(), "Service Protect Transactions", "ProtectTransactions", "", null,
                                    request.CIF.Trim(), JsonConvert.SerializeObject(request), JsonConvert.SerializeObject(result), result.ResponseCode,
                                    result.Message, result.Message, request.ChannelID.Trim(), DateTime.Now);
            }
            return result;
        }
    }
}
