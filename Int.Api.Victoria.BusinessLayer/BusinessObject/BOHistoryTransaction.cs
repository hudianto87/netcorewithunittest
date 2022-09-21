using Int.Api.Victoria.BusinessLayer.BindingModel;
using Int.Api.Victoria.BusinessLayer.BindingModelResult;
using Int.Api.Victoria.BusinessLayer.BusinessObject.Master;
using Int.Api.Victoria.BusinessLayer.Interface;
using Int.Api.Victoria.DataAccess.Context;
using Int.Api.Victoria.DataAccess.Models;
using Newtonsoft.Json;

namespace Int.Api.Victoria.BusinessLayer.BusinessObject
{
    public class BOHistoryTransaction : IBOHistoryTransaction
    {
        private readonly Reference boReference;
        private readonly ResponseCode.ResponseCode responseCode;
        private readonly BOLogger boLogger;
        public BOHistoryTransaction(DBContext db)
        {
            boReference = new(db);
            responseCode = new();
            boLogger = new(db);
        }
        public async Task<ResultBase<List<BMRHistoryTransaction>>> InquiryTransaction(BMHistoryTransaction request)
        {
            var result = new ResultBase<List<BMRHistoryTransaction>>()
            {
                Data = new()
            };
            List<Ttransaction> resultDataTransaction = new();
            bool useDate = false;
            string[]? statusTransactions = null;
            string tempStatus = string.Empty;
            try
            {
                #region Validation Request Begin Date And End Date
                if (!request.BeginDate.HasValue && !request.EndDate.HasValue)
                {
                    useDate = false;
                }
                else if (!request.BeginDate.HasValue)
                {
                    request.BeginDate = DateTime.Now.Date;
                    useDate = true;
                }
                else if (!request.EndDate.HasValue)
                {
                    request.EndDate = DateTime.Now;
                    if (request.EndDate < request.BeginDate)
                    {
                        result.IsOk = false;
                        result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS106);
                        result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS106.ToString();
                        return result;
                    }
                    useDate = true;
                }
                else if (request.BeginDate.HasValue && request.EndDate.HasValue)
                {
                    if (request.EndDate < request.BeginDate)
                    {
                        result.IsOk = false;
                        result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS106);
                        result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS106.ToString();
                        return result;
                    }
                    useDate = true;
                }
                #endregion

                #region Mapping Request Status
                if (request.Status.ToUpper().Trim().Equals("ALL"))
                {
                    statusTransactions = new[] { "VERIFIED", "APPROVED", "SETTLED" };
                }
                if (request.Status.ToUpper().Trim().Equals("ONPROCESS"))
                {
                    statusTransactions = new[] { "VERIFIED" };
                }
                if (request.Status.ToUpper().Trim().Equals("SUCCESS"))
                {
                    statusTransactions = new[] { "APPROVED", "SETTLED" };
                }
                #endregion

                #region Validation Get Data Channel ID
                List<VTreferenceDetail> getDataChannel = await boReference.GetReferenceByGroupname("TRefTransactionGenerator");
                VTreferenceDetail? DataChannel = new();
                if (getDataChannel != null)
                {
                    DataChannel = getDataChannel.Where(x => x.Display.Equals(request.ChannelID.ToUpper().Trim())).FirstOrDefault();
                }

                if (getDataChannel == null || DataChannel == null)
                {
                    result.IsOk = false;
                    result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS018);
                    result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS018.ToString();
                    return result;
                }
                #endregion

                #region Validation Get Data CIF
                Tcustomer? getDataCustomer = await boReference.GetCustomerByCif(request.CIF.Trim());
                if (getDataCustomer == null)
                {
                    result.IsOk = false;
                    result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS006);
                    result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS006.ToString();
                    return result;
                }
                #endregion

                #region Process Inquiry Transaction
                if (useDate)
                {
                    resultDataTransaction = await boReference.GetDataTransactionByIDCustomerAndDate(getDataCustomer.Idcustomer, request.BeginDate, request.EndDate, statusTransactions);
                }
                else
                {
                    resultDataTransaction = await boReference.GetDataTransactionByIDCustomer(getDataCustomer.Idcustomer, statusTransactions);
                }

                if (resultDataTransaction.Count > 0)
                {
                    for (int i = 0; i < resultDataTransaction.Count; i++)
                    {
                        if (resultDataTransaction[i].Idcategory.Equals("SUB") || 
                            resultDataTransaction[i].Idcategory.Equals("RED") || 
                            resultDataTransaction[i].Idcategory.Equals("SWTOUT") ||
                            resultDataTransaction[i].Idcategory.Equals("SWTIN"))
                        {
                            TtransactionBankAccount? resultTransBankAccount = await boReference.GetDataBankAccountByIDTransaction(resultDataTransaction[i].Idtransaction);
                            BMRHistoryTransaction ListTransaction = new()
                            {
                                IDTransaction = resultDataTransaction[i].Idtransaction,
                                IDCategory = resultDataTransaction[i].Idcategory,
                                IDStatus = resultDataTransaction[i].Idstatus,
                                TransactionDate = resultDataTransaction[i].TransactionDate,
                                ReferenceNo = resultDataTransaction[i].ReferenceNo,
                                ProductCode = resultDataTransaction[i].IdproductNavigation.ProductCode,
                                ProductName = resultDataTransaction[i].IdproductNavigation.ProductName,
                                ProductCategory = resultDataTransaction[i].IdproductNavigation.Idcategory,
                                AccountNo = resultTransBankAccount.AccountNo,
                                AccountName = resultTransBankAccount.AccountName,
                                FeeAmount = resultDataTransaction[i].FeeAmount,
                                FeeTaxAmount = resultDataTransaction[i].FeeTax,
                                NetAmount = resultDataTransaction[i].NetAmount,
                                Unit = resultDataTransaction[i].Units,
                                NAVValue = resultDataTransaction[i].Navvalue,
                                TotalAmount = resultDataTransaction[i].NetAmount + resultDataTransaction[i].FeeAmount + resultDataTransaction[i].FeeTax
                            };

                            result.Data.Add(ListTransaction);
                        }
                    }
                }
                #endregion
            }
            catch (Exception ex)
            {
                result.IsOk = false;
                result.Message = ex.Message + " " + responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS999);
                result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS999.ToString();
                return result;
            }
            finally
            {
                await boLogger.SaveLog("IN", request.ChannelID.Trim(), "Service History Transaction", "HistoryTransaction", "", null,
                                    request.CIF.Trim(), JsonConvert.SerializeObject(request), JsonConvert.SerializeObject(result), result.ResponseCode,
                                    result.Message, result.Message, request.ChannelID.Trim(), DateTime.Now);
            }
            return result;
        }
    }
}
