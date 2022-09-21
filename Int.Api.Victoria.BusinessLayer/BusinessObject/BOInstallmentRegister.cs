using Int.Api.Victoria.BusinessLayer.BindingModel;
using Int.Api.Victoria.BusinessLayer.BindingModelResult;
using Int.Api.Victoria.BusinessLayer.BusinessObject.Master;
using Int.Api.Victoria.BusinessLayer.Interface;
using Int.Api.Victoria.DataAccess.Context;
using Int.Api.Victoria.DataAccess.Models;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace Int.Api.Victoria.BusinessLayer.BusinessObject
{
    public class BOInstallmentRegister : IBOInstallmentRegister
    {
        private readonly DBContext dB;
        private readonly Reference reference;
        private readonly ResponseCode.ResponseCode responseCode;
        private readonly IConfiguration config;
        private readonly BOSubAccount subaccount;
        private readonly BOCustomerRegInvestmentPlan bOCustomerRegInvestmentPlan;
        private readonly BOLogger boLogger;
        public BOInstallmentRegister(DBContext dBContext, IConfiguration configuration)
        {
            dB = dBContext;
            reference = new Reference(dBContext);
            responseCode = new();
            config = configuration;
            subaccount = new BOSubAccount(dBContext);
            bOCustomerRegInvestmentPlan = new BOCustomerRegInvestmentPlan(dBContext);
            boLogger = new(dBContext);
        }
        public async Task<ResultBase<BMRInstallmentRegister>> InstallmentRegister(BMInstallmentRegister RequestInstallmentRegister)
        {
            var result = new ResultBase<BMRInstallmentRegister>
            {
                Data = new()
            };

            try
            {                

                DateTime rightNow = DateTime.Now;
                DateTime StartDate = DateTime.Now;
                DateTime EndDate = DateTime.Now;
                int channelid;
                byte subAccountType = 0, subAccountTypeGenerator = 0;
                int TRegInvestPlanID = 0;
                double feePercentage, taxPercentage = 0;
                double fee = 0, feeTax = 0;

                if (rightNow.Day < RequestInstallmentRegister.CycleDate)
                {
                    StartDate = new DateTime(StartDate.Year, StartDate.Month, RequestInstallmentRegister.CycleDate);
                    EndDate = new DateTime(EndDate.Year, EndDate.Month, RequestInstallmentRegister.CycleDate).AddMonths(RequestInstallmentRegister.Tenor);
                }
                else
                {
                    StartDate = new DateTime(StartDate.Year, StartDate.Month, RequestInstallmentRegister.CycleDate).AddMonths(1);
                    EndDate = new DateTime(EndDate.Year, EndDate.Month, RequestInstallmentRegister.CycleDate).AddMonths(RequestInstallmentRegister.Tenor + 1);
                }

                if (RequestInstallmentRegister.Planning.Equals("CRISP"))
                {
                    subAccountType = 2;
                    TRegInvestPlanID = 1;
                    subAccountTypeGenerator = 1;
                }
                else if (RequestInstallmentRegister.Planning.Equals("CRISPPLUS"))
                {
                    subAccountType = 3;
                    TRegInvestPlanID = 2;
                    subAccountTypeGenerator = 2;
                }

                #region validation
                VTreferenceDetail? vchannel = await reference.GetChannel(RequestInstallmentRegister.ChannelID);
                if (vchannel == null)
                {
                    result.IsOk = false;
                    result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS018); ;
                    result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS018.ToString();
                    return result;
                }

                Tcustomer? tcustomer = await reference.GetCustomerByCif(RequestInstallmentRegister.CIF);
                if (tcustomer == null)
                {
                    result.IsOk = false;
                    result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS006); ;
                    result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS006.ToString();
                    return result;
                }

                TcustBankAccount? tcustBankAccount = await reference.GetDataBankAccountByAccountNo(RequestInstallmentRegister.CustomerAccountNo);
                if (tcustBankAccount == null)
                {
                    result.IsOk = false;
                    result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS013); ;
                    result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS013.ToString();
                    return result;
                }

                if (tcustBankAccount != null && tcustBankAccount.IsTaxAmnesty == true)
                {
                    result.IsOk = false;
                    result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS101); ;
                    result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS101.ToString();
                    return result;
                }

                Tproduct? tproduct = await reference.GetProductByProductcode(RequestInstallmentRegister.ProductCode);
                if (tproduct == null)
                {
                    result.IsOk = false;
                    result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS007); ;
                    result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS007.ToString();
                    return result;
                }

                channelid = int.Parse(vchannel.MainValue);

                TproductRegInvestmentPlan tproductRegInvestmentPlan = await reference.GetProductInvestmentPlan(tproduct.Idproduct, TRegInvestPlanID, true, channelid, DateTime.Now.Date);
                if (tproductRegInvestmentPlan == null)
                {
                    result.IsOk = false;
                    result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS102); ;
                    result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS102.ToString();
                    return result;
                }

                //string AgentCode = config["ECHANNELAGENT"];
                Tagent? _Agent = await reference.GetDataAgent(RequestInstallmentRegister.ChannelID.Trim());

                if (_Agent == null)
                {
                    result.IsOk = false;
                    result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS054); ;
                    result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS054.ToString();
                    return result;
                }
                #endregion

                #region Process
                TregularInvestmentPlanFeeDetail tregularInvestmentPlanFeeDetail = await reference.GetFeeByTenorAndAmount(tproductRegInvestmentPlan.TregularInvestmentPlanFeeId, RequestInstallmentRegister.Tenor, RequestInstallmentRegister.Amount);
                if(tregularInvestmentPlanFeeDetail != null)
                {
                    feePercentage = tregularInvestmentPlanFeeDetail.FeePercentage;
                }
                else
                {
                    result.IsOk = false;
                    result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS103); ;
                    result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS103.ToString();
                    return result;
                }

                List<TcustomerRegInvestmentPlan> CustRegPlanz = await reference.TCustomerRegInvestmentPlan_SelectByCustomerProduct(tcustomer.Idcustomer,tproduct.Idproduct);
                TsubAccount SubAccount = new();
                
                if (RequestInstallmentRegister.Planning.Equals("CRISP"))
                {
                    CustRegPlanz = CustRegPlanz.Where(c => c.TregularInvestmentPlanId == 1).ToList();
                }
                else if (RequestInstallmentRegister.Planning.Equals("CRISPPLUS"))
                {
                    CustRegPlanz = CustRegPlanz.Where(c => c.TregularInvestmentPlanId == 2).ToList();
                }

                if (CustRegPlanz.Count > 0)
                {
                    TcustomerRegInvestmentPlan tcrip = CustRegPlanz.OrderByDescending(x => x.SysCreatedTime).FirstOrDefault();
                    SubAccount = await reference.GetSubAccountByIDSubAccount(tcrip.IdsubAccount);
                }
                else
                {
                    string newSubAccountNo = await reference.GenerateNewSubAccount(tcustomer.Idcustomer, tproduct.Idproduct, subAccountTypeGenerator);

                    TsubAccount tsubAccount = new TsubAccount()
                    {
                        NoAccount = newSubAccountNo,
                        Idcustomer = tcustomer.Idcustomer,
                        Idproduct = tproduct.Idproduct,
                        CreatedDate = DateTime.Now,
                        CreatedBy = RequestInstallmentRegister.ChannelID,
                        SubAccountType = 2
                    };

                    SubAccount = await subaccount.TSubAccount(tsubAccount);
                }
                Tconfig? configtaxPercentage = await reference.GetConfigByKey("UI.Transaction.Fee.Tax.Value");
                if(configtaxPercentage != null)
                {
                    taxPercentage = double.Parse(configtaxPercentage.Value);
                }

                fee = RequestInstallmentRegister.Amount * (feePercentage / 100);
                feeTax = fee * taxPercentage;

                TcustomerRegInvestmentPlan tcustomerRegInvestmentPlan = new TcustomerRegInvestmentPlan()
                {
                    TregularInvestmentPlanId = tproductRegInvestmentPlan.TregularInvestmentPlanId,
                    Idproduct = tproduct.Idproduct,
                    Idcustomer = tcustomer.Idcustomer,
                    CustAccountNo = RequestInstallmentRegister.CustomerAccountNo,
                    Tenor = RequestInstallmentRegister.Tenor,
                    ReferenceNo = RequestInstallmentRegister.RefNo,                    
                    NetAmount = RequestInstallmentRegister.Amount,                    
                    Fee = feePercentage,
                    FeeAmount = fee,
                    FeeTax = feeTax,
                    Amount = RequestInstallmentRegister.Amount + fee + feeTax,
                    RegDate = DateTime.Now,
                    DebitDate = Convert.ToByte(RequestInstallmentRegister.CycleDate),
                    FeeMethod = "NETT",
                    AdjustFeeType = "PERCENTAGE",
                    GeneratorId = short.Parse(vchannel.MainValue),
                    Idsales = _Agent.AgentId,
                    SysCreatedBy = RequestInstallmentRegister.ChannelID,
                    SysCreatedTime = DateTime.Now,
                    SysCreatedHost = RequestInstallmentRegister.ChannelID,
                    SysActionType = "I",
                    SysApprovalStatus = 1,
                    SysRecStatus = true,
                    IdsubAccount = SubAccount.IdsubAccount
                };

                TcustomerRegInvestmentPlan tcustomerRegInvestmentPlan1 = await bOCustomerRegInvestmentPlan.CustomerRegInvestmentPlan(tcustomerRegInvestmentPlan);

                #endregion

                result.Data.CIF = tcustomer.UnitHolderIdno;
                result.Data.ProductCode = tproduct.ProductCode;
                result.Data.CustomerAccountNo = tcustomerRegInvestmentPlan1.CustAccountNo;
                result.Data.Amount = tcustomerRegInvestmentPlan1.Amount;
                result.Data.FeeAmount = tcustomerRegInvestmentPlan1.FeeAmount;
                result.Data.TaxAmount = tcustomerRegInvestmentPlan1.FeeTax;
                result.Data.NetAmount = tcustomerRegInvestmentPlan1.NetAmount;
                result.Data.Tenor = tcustomerRegInvestmentPlan1.Tenor;
                result.Data.CycleDate = tcustomerRegInvestmentPlan1.DebitDate;
                result.Data.Planning = RequestInstallmentRegister.Planning;
                result.Data.RefNo = RequestInstallmentRegister.RefNo;
                result.Data.RegisterID = tcustomerRegInvestmentPlan1.TcustomerRegInvestmentPlanId;
                result.Data.FirstDebit = StartDate.ToString("yyyy-MM-dd");
            }
            catch (Exception ex)
            {
                result.IsOk = false;
                result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS999);
                result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS999.ToString();
            }
            finally
            {
                await boLogger.SaveLog("IN", RequestInstallmentRegister.ChannelID.Trim(), "Service Installment Register", "InstallmentRegister", "", null,
                                    RequestInstallmentRegister.CIF.Trim(), JsonConvert.SerializeObject(RequestInstallmentRegister), JsonConvert.SerializeObject(result), result.ResponseCode,
                                    result.Message, result.Message, RequestInstallmentRegister.ChannelID.Trim(), DateTime.Now);
            }
            return result;
        }
    }
}
