using Int.Api.Victoria.BusinessLayer.BindingModel;
using Int.Api.Victoria.BusinessLayer.BindingModelResult;
using Int.Api.Victoria.BusinessLayer.BusinessObject.Master;
using Int.Api.Victoria.BusinessLayer.Custom;
using Int.Api.Victoria.DataAccess.Context;
using Int.Api.Victoria.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace Int.Api.Victoria.BusinessLayer.BusinessObject
{
    public class BOCustomerPortfolio
    {
        private readonly DBContext dbContext;
        private readonly Reference boReference;
        private readonly ResponseCode.ResponseCode responseCode;
        private readonly CustomFunction customFunction;
        private readonly Holiday holiday;
        private readonly BOLogger boLogger;
        public BOCustomerPortfolio(DBContext db)
        {
            dbContext = db;
            boReference = new(db);
            responseCode = new();
            customFunction = new();
            holiday = new(db);
            boLogger = new(db);
        }
        public async Task<ResultBase<BMRCustomerPortfolio>> GetDataCustomerPortfolio(BMCustomerPortfolio request)
        {
            DateTime _Date = DateTime.Now;
            string[] idStatus = { "APPROVED", "SETTLED" };
            var result = new ResultBase<BMRCustomerPortfolio>()
            {
                Data = new()
            };

            Tproduct? resultDataProduct = new();

            try
            {
                #region Validation Get Data Channel
                List<VTreferenceDetail> getDataChannel = await boReference.GetReferenceByGroupname("TRefTransactionGenerator");
                VTreferenceDetail? DataChannel = new();
                if (getDataChannel != null)
                {
                    DataChannel = getDataChannel.Where(x => x.Display.Equals(request.ChannelID.Trim())).FirstOrDefault();
                }

                if (getDataChannel is null || DataChannel is null)
                {
                    result.IsOk = false;
                    result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS018);
                    result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS018.ToString();
                    return result;
                }
                #endregion

                #region Validation Get Data Customer
                Tcustomer? dataCustomer = await boReference.GetCustomerByCif(request.CIF.Trim());
                if (dataCustomer is null)
                {
                    result.IsOk = false;
                    result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS006);
                    result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS006.ToString();
                    return result;
                }
                #endregion

                #region Validation Get Data Product
                if (!string.IsNullOrEmpty(request.ProductCode.Trim()))
                {
                    resultDataProduct = await boReference.GetProductByProductcode(request.ProductCode.Trim());
                    if (resultDataProduct is null)
                    {
                        result.IsOk = false;
                        result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS007);
                        result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS007.ToString();
                        return result;
                    }
                }
                #endregion

                #region Process Get Data Customer Portfolio
                var tcustomerRiskProfiles = await (from trp in dbContext.TcustomerRiskProfiles.AsNoTracking()
                                                   join tref in dbContext.TrefProfiles.AsNoTracking()
                                                        on trp.ProfileId equals tref.ProfileId
                                                   where trp.Idcustomer.Equals(dataCustomer.Idcustomer)
                                                   && trp.EffectiveDate <= _Date
                                                   orderby trp.EffectiveDate descending
                                                   select new
                                                   {
                                                       CustRiskProfileType = tref.ProfileName,
                                                       CustRiskProfilingDate = customFunction.ConvertDateToStringFormatESB(trp.EffectiveDate),
                                                       CustRiskProfileExpiredDate = customFunction.ConvertDateToStringFormatESB(trp.ExpireDate)
                                                   }).FirstOrDefaultAsync();

                if (tcustomerRiskProfiles is null)
                {
                    result.IsOk = false;
                    result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS017);
                    result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS017.ToString();
                    return result;
                }

                result.Data.CIF = request.CIF;
                result.Data.CustRiskProfileType = tcustomerRiskProfiles.CustRiskProfileType;
                result.Data.CustRiskProfilingDate = tcustomerRiskProfiles.CustRiskProfilingDate;
                result.Data.CustRiskProfileExpiredDate = tcustomerRiskProfiles.CustRiskProfileExpiredDate;
                result.Data.CurrencyDate = customFunction.ConvertDateToStringFormatESB(_Date);

                if (request.Category.Trim().Equals("MF") || request.Category.Trim().Equals("ALL") || string.IsNullOrEmpty(request.Category.Trim()))
                {
                    List<fn_TOutstandingHistoryFIFO_GetBalancePerProduct> OutstandingBalanceProduct = new();
                    switch (resultDataProduct.Idproduct == 0)
                    {
                        case true:
                            OutstandingBalanceProduct = await dbContext.fn_TOutstandingHistoryFIFO_GetBalancePerProduct.FromSqlRaw("Select * from fn_TOutstandingHistoryFIFO_GetBalancePerProduct({0},{1},{2})", dataCustomer.Idcustomer, null, _Date).ToListAsync();
                            break;

                        case false:
                            OutstandingBalanceProduct = await dbContext.fn_TOutstandingHistoryFIFO_GetBalancePerProduct.FromSqlRaw("Select * from fn_TOutstandingHistoryFIFO_GetBalancePerProduct({0},{1},{2})", dataCustomer.Idcustomer, resultDataProduct.Idproduct, _Date).ToListAsync();
                            break;
                    }

                    if (OutstandingBalanceProduct is null)
                    {
                        result.IsOk = false;
                        result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS051);
                        result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS051.ToString();
                        return result;
                    }

                    foreach (var item in OutstandingBalanceProduct)
                    {
                        DateTime _BeginDate, _EndDate;
                        double UGLBalance = 0, UGLPercentage = 0, BalanceUnit = 0, AVGUnitCost = 0, TAVGUnitCost = 0, rate = 1, _AmountInIDR = 0, _Amount = 0, _Units = 0, _RedUnits = 0;
                        string _InvType = string.Empty;
                        

                        //Validation Check Product Again
                        Tproduct? getDataByIdProduct = await boReference.GetProductByIdProduct(item.IDProduct);

                        if (getDataByIdProduct is null)
                        {
                            result.IsOk = false;
                            result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS105);
                            result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS105.ToString();
                            return result;
                        }

                        if (!getDataByIdProduct.Idstatus)
                        {
                            result.IsOk = false;
                            result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS088);
                            result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS088.ToString();
                            return result;
                        }

                        Tnav? tnav = await dbContext.Tnavs.Where(x => x.Idproduct.Equals(getDataByIdProduct.Idproduct) && EF.Functions.DateDiffDay(x.Navdate, _Date) >= 0).OrderByDescending(x => x.Idnav).FirstOrDefaultAsync();
                        if (getDataByIdProduct.Idcurrency != 1)
                        {
                            TexchangeRate? texchangeRate = await dbContext.TexchangeRates.Where(x => x.CcurrencyId == getDataByIdProduct.Idcurrency && x.TcurrencyId == 1).FirstOrDefaultAsync();
                            if (texchangeRate != null)
                            {
                                rate = (texchangeRate.Bid + texchangeRate.Offer) / 2;
                            }
                        }

                        TfundHouse? tfundHouse = await boReference.GetFhId(getDataByIdProduct.FhId);
                        TrefCurrency? trefCurrency = await boReference.GetDataCurrency(getDataByIdProduct.Idcurrency);
                        TproductBankAccount? tproductBankAccount = await boReference.GetDataProductBankAccountByIDProduct(getDataByIdProduct.Idproduct);

                        InvestmentAccount investmentAccount = new()
                        {
                            TransactionList = new List<RInqCustPortfolio_Product_Transaction>()
                        };

                        _Units = Convert.ToDouble(item.BalanceUnit);
                        _Amount = _Units * tnav.Value;
                        _AmountInIDR = _Amount * rate;

                        string InvestmentType;
                        Ttransaction? ttransaction = await boReference.GetDataTTransactionByIDSubAccount(item.IDSubAccount);
                        if (ttransaction.GeneratorId == 7)
                        {
                            long _genId = long.Parse(ttransaction.GeneratorData1.Split(',').First());
                            TcustomerRegInvestmentPlan? tcustomerRegInvestmentPlan = await boReference.GetDataTcustomerRegInvestmentPlan(_genId);
                            TregularInvestmentPlan? tregularInvestmentPlan = await boReference.GetDataTregularInvestmentPlan(tcustomerRegInvestmentPlan.TcustomerRegInvestmentPlanId);
                            InvestmentType = tregularInvestmentPlan.InvestmentPlanCode;
                        }
                        else
                        {
                            InvestmentType = "Reguler";
                        }

                        if (request.BeginDate != null && request.BeginDate != "")
                            _BeginDate = Convert.ToDateTime(request.BeginDate);
                        else
                            _BeginDate = DateTime.Now.AddYears(-100);

                        if (request.EndDate != null && request.EndDate != "")
                            _EndDate = Convert.ToDateTime(request.EndDate);
                        else
                            _EndDate = DateTime.Now;

                        _EndDate = holiday.AddDate(_EndDate, 1, getDataByIdProduct.Idcurrency);

                        /*ambil list 10 trx terakhir berdasarkan idsubaccount*/
                        List<Ttransaction> ListDataTTransactions = await boReference.GetDataListTTransactionByIDSubAccount(item.IDSubAccount, idStatus, _BeginDate, _EndDate);
                        foreach (var itemListTransactions in ListDataTTransactions)
                        {
                            RInqCustPortfolio_Product_Transaction rInqCustPortfolio_Product_Transaction = new()
                            {
                                TransactionDate = customFunction.ConvertDateToStringFormatESB((DateTime)itemListTransactions.TransactionDate),
                                TransactionType = itemListTransactions.Idcategory,
                                Unit = customFunction.BuildAmount((double)itemListTransactions.Units, 4),
                                NAVPerUnitTrx = customFunction.BuildAmount(Convert.ToDouble(itemListTransactions.Navvalue), 6),
                                NAVDateTrx = customFunction.ConvertDateToStringFormatESB((DateTime)itemListTransactions.Navdate),
                                AmountTrx = customFunction.BuildAmount(Convert.ToDouble(itemListTransactions.Amount), 2),
                                FeeAmount = customFunction.BuildAmount(Convert.ToDouble(itemListTransactions.FeeAmount), 2),
                                TaxAmount = customFunction.BuildAmount(Convert.ToDouble(itemListTransactions.FeeTax), 2),
                                Charges = customFunction.BuildAmount(Convert.ToDouble(itemListTransactions.Charges), 2),
                                NetAmount = customFunction.BuildAmount(Convert.ToDouble(itemListTransactions.NetAmount), 2)
                            };

                            if (itemListTransactions.Idcategory == "SWTOT")
                            {
                                //rInqCustPortfolio_Product_Transaction.ProductFrom = dB.Tproduct.Where(x => x.Idproduct == itemListTransactions.Idproduct).FirstOrDefault().ProductCode;
                                rInqCustPortfolio_Product_Transaction.ProductFrom = await dbContext.Tproducts.Where(x => x.Idproduct == itemListTransactions.Idproduct).Select(x => x.ProductCode).FirstOrDefaultAsync();
                            }

                            if (itemListTransactions.Idcategory == "SWTIN")
                            {
                                //var trxSouce = dB.Ttransaction.Where(x => x.Idtransaction == itemListTransactions.SourceIdtransaction).FirstOrDefault();
                                var trxSouce = await dbContext.Ttransactions.Where(x => x.Idtransaction == itemListTransactions.SourceIdtransaction).FirstOrDefaultAsync();

                                //rInqCustPortfolio_Product_Transaction.ProductTo = dB.Tproduct.Where(x => x.Idproduct == trxSouce.Idproduct).FirstOrDefault().ProductCode;
                                rInqCustPortfolio_Product_Transaction.ProductTo = await dbContext.Tproducts.Where(x => x.Idproduct == trxSouce.Idproduct).Select(x => x.ProductCode).FirstOrDefaultAsync();
                                rInqCustPortfolio_Product_Transaction.UnitTo = customFunction.BuildAmount((double)trxSouce.Units, 4);
                                rInqCustPortfolio_Product_Transaction.NAVPerUnitTo = customFunction.BuildAmount(Convert.ToDouble(trxSouce.Navvalue), 6);
                            }
                            investmentAccount.TransactionList.Add(rInqCustPortfolio_Product_Transaction);
                        }

                        /*hitung trx gantung*/
                        List<Ttransaction> ttransactionsGantung = await boReference.TtransactionPendByIDSubAccount(item.IDSubAccount, _BeginDate, _EndDate);

                        foreach (var itemGantung in ttransactionsGantung)
                        {
                            double unit = Convert.ToDouble(itemGantung.Units);

                            _RedUnits += unit;
                        }
                        _Units -= _RedUnits;
                        _Amount = _Units * tnav.Value;

                        investmentAccount.InvestmentAccountNo = item.NoAccount;
                        investmentAccount.InvestmentType = InvestmentType;
                        investmentAccount.Units = customFunction.BuildAmount(_Units, 4);
                        investmentAccount.Amount = customFunction.BuildAmount(_Amount, 2);

                        _AmountInIDR = _Amount * rate;

                        BalanceUnit += Convert.ToDouble(_Units);
                        AVGUnitCost += Convert.ToDouble(item.AvgUnitCost) * Convert.ToDouble(_Units);

                        TAVGUnitCost = AVGUnitCost / BalanceUnit;
                        if (double.IsNaN(TAVGUnitCost))
                        {
                            TAVGUnitCost = 0;
                        }

                        UGLBalance = BalanceUnit * (tnav.Value - TAVGUnitCost);
                        UGLPercentage = (BalanceUnit * (tnav.Value - TAVGUnitCost) * 100) / (BalanceUnit * tnav.Value);

                        if (double.IsNaN(UGLPercentage))
                        {
                            UGLPercentage = 0;
                        }

                        UGLBalance = !string.IsNullOrEmpty(UGLBalance.ToString()) ? double.Parse(UGLBalance.ToString()) : 0;
                        UGLPercentage = !string.IsNullOrEmpty(UGLPercentage.ToString()) ? double.Parse(UGLPercentage.ToString()) : 0;

                        RInqCustPortfolio_Product RInqCustPortfolio_Products = new()
                        {
                            ProductCode = getDataByIdProduct.ProductCode,
                            ProductName = getDataByIdProduct.ProductName,
                            ProductCategory = "MF",
                            FundHouseCode = tfundHouse.FhCode,
                            FundHouseName = tfundHouse.Name,
                            Currency = trefCurrency.CurrencyCode,
                            CurrencyRate = customFunction.BuildAmount(rate, 2),
                            ProdBankAccount = tproductBankAccount.AccountNo,
                            NAVDate = customFunction.ConvertDateToStringFormatESB(tnav.Navdate),
                            NAVPerUnit = customFunction.BuildAmount(tnav.Value, 6),
                            UGL = customFunction.BuildAmount(UGLBalance, 2),
                            UGLPercentage = customFunction.BuildAmount(UGLPercentage, 2),
                            UGLFlag = UGLPercentage < 0 ? false : true,
                            TotalAmount = customFunction.BuildAmount(_Amount, 2),
                            TotalAmountInIDR = customFunction.BuildAmount(_AmountInIDR, 2),
                            TotalUnits = customFunction.BuildAmount(_Units, 4),
                            InvestmentAccountList = new List<InvestmentAccount>()
                        };

                        RInqCustPortfolio_Products.InvestmentAccountList.Add(investmentAccount);
                        result.Data.ProductList.Add(RInqCustPortfolio_Products);
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
                await boLogger.SaveLog("IN", request.ChannelID.Trim(), "Service Customer Portfolio", "CustomerPortfolio", "", null,
                                    request.CIF.Trim(), JsonConvert.SerializeObject(request), JsonConvert.SerializeObject(result), result.ResponseCode,
                                    result.Message, result.Message, request.ChannelID.Trim(), DateTime.Now);
            }

            return result;
        }
    }
}
