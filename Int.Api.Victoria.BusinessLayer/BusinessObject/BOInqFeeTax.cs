using Int.Api.Victoria.BusinessLayer.BindingModel;
using Int.Api.Victoria.BusinessLayer.BindingModelResult;
using Int.Api.Victoria.BusinessLayer.BusinessObject.Master;
using Int.Api.Victoria.BusinessLayer.Interface;
using Int.Api.Victoria.DataAccess.Context;
using Int.Api.Victoria.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace Int.Api.Victoria.BusinessLayer.BusinessObject
{
    public class BOInqFeeTax : IBOInqFeeTax
    {
        private readonly DBContext dbContext;
        private readonly Reference boReference;
        private readonly ResponseCode.ResponseCode responseCode;
        private readonly BOLogger boLogger;
        public BOInqFeeTax(DBContext db)
        {
            dbContext = db;
            boReference = new Reference(dbContext);
            responseCode = new();
            boLogger = new(db);
        }
        public async Task<ResultBase<BMRInqFeeTax>> ProcessInquiryFeeTax(BMInqFeeTax requestFeeTax)
        {
            var result = new ResultBase<BMRInqFeeTax>
            {
                Data = new()
            };

            string[]? productCategory = null;
            double NAV = 0, FeePercentage = 0;
            string strcurrencyCode = "IDR";
            bool IsAfter = false;
            string keyCOT = string.Empty;
            TimeSpan timeSpan = new(12, 00, 00);
            int resultDOW = (int)DateTime.Now.DayOfWeek + 1; // Ditambah 1 karena, hari minggu dihitung dari angka 0
            try
            {
                #region Process Request Validation

                #region Validation Request Get Data Channel and Config Key
                VTreferenceDetail? getDataChannel = await boReference.GetChannel(requestFeeTax.ChannelID.Trim());
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

                #region Validation Request Get Data CIF
                Tcustomer? dataCustomer = await boReference.GetCustomerByCif(requestFeeTax.CIF.Trim());
                if (dataCustomer == null)
                {
                    result.IsOk = false;
                    result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS006);
                    result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS006.ToString();
                    return result;
                }
                #endregion

                #region Validation Request Data Product cannot be NULL and Product Type must CLOSE
                Tproduct? dataProduct = await boReference.GetProductByProductcode(requestFeeTax.ProductCode);
                if (dataProduct == null)
                {
                    result.IsOk = false;
                    result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS007);
                    result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS007.ToString();
                    return result;
                }

                if (!dataProduct.Idmftype.Equals("OPEN"))
                {
                    result.IsOk = false;
                    result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS074);
                    result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS074.ToString();
                    return result;
                }
                #endregion

                #region Validation Request RED & SWT Category Transaction
                if (requestFeeTax.TransactionCategory.Trim().Equals("SWT") && string.IsNullOrEmpty(requestFeeTax.ProductCodeTo))
                {
                    result.IsOk = false;
                    result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS073);
                    result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS073.ToString();
                    return result;
                }
                if (requestFeeTax.TransactionCategory.ToUpper().Trim().Equals("RED") || requestFeeTax.TransactionCategory.ToUpper().Trim().Equals("SWT"))
                {
                    foreach (var transValueRedSwt in requestFeeTax.transactionValue)
                    {
                        if (string.IsNullOrEmpty(transValueRedSwt.InvAccountNo))
                        {
                            result.IsOk = false;
                            result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS069);
                            result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS069.ToString();
                            return result;
                        }

                        if (transValueRedSwt.Units == 0)
                        {
                            result.IsOk = false;
                            result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS070);
                            result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS070.ToString();
                            return result;
                        }
                    }
                }
                #endregion

                #region Validation Request SUB Category Transaction And Product Must Allow Subscription
                if (requestFeeTax.TransactionCategory.Trim().Equals("SUB"))
                {
                    foreach (var transValueSub in requestFeeTax.transactionValue)
                    {
                        if (transValueSub.NetAmount == 0)
                        {
                            result.IsOk = false;
                            result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS071);
                            result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS071.ToString();
                            return result;
                        }
                    }
                }
                #endregion

                #endregion

                #region Process Response And Validation Inquiry Fee Tax

                #region Get Data Currency
                var getDataCurrency = await dbContext.TrefCurrencies.Where(x => x.Idcurrency == dataProduct.Idcurrency).FirstOrDefaultAsync();
                if (getDataCurrency == null)
                {
                    result.IsOk = false;
                    result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS083);
                    result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS083.ToString();
                    return result;
                }
                strcurrencyCode = getDataCurrency.CurrencyCode;

                /*if (!string.IsNullOrEmpty(getDataCurrency.CurrencyCode) && !getDataCurrency.CurrencyCode.Trim().Equals("IDR")) // if currency not IDR, always set exchangeRate = 1
                    exchangeRate = 0;*/
                #endregion

                #region COT (Cut Off Time)
                switch (requestFeeTax.TransactionCategory)
                {
                    case "SUB":
                        keyCOT = requestFeeTax.ChannelID + ".Transaction.Sub.Entry.CutOffTime";
                        break;
                    case "RED":
                        keyCOT = requestFeeTax.ChannelID + ".Transaction.Red.Entry.CutOffTime";
                        break;
                    default:
                        keyCOT = requestFeeTax.ChannelID + ".Transaction.Swt.Entry.CutOffTime";
                        break;
                }

                var resultCOT = await boReference.GetConfigByKey(keyCOT);
                if (resultCOT != null)
                {
                    string[] timeConfig = resultCOT.Value.Split(':');
                    timeSpan = new TimeSpan(Convert.ToInt32(timeConfig[0]), Convert.ToInt32(timeConfig[1]), 0);
                }

                bool _isHoliday = await boReference.GetDataHoliday(getDataCurrency.Idcurrency, resultDOW);
                if ((DateTime.Now.Hour > timeSpan.Hours) || ((DateTime.Now.Hour == timeSpan.Hours) && (DateTime.Now.Minute > timeSpan.Minutes)) || _isHoliday)
                {
                    IsAfter = true;
                    //TODO
                    //_NAVDate = HARI KERJA BERIKUTNYA. Menggunakan dbo.fn_THoliday_AddDate
                }
                #endregion

                #region Get Data Customer Bank Account
                TcustBankAccount? tcustBankAccount = await boReference.GetDataBankAccount(dataCustomer.Idcustomer);
                if (tcustBankAccount == null)
                    result.Data.CustBankAccountNo = string.Empty;
                else
                    result.Data.CustBankAccountNo = tcustBankAccount.AccountNo;
                #endregion

                #region Validation Category Subscription Transaction
                if (requestFeeTax.TransactionCategory.Trim().Equals("SUB") && !dataProduct.AllowSubscription)
                {
                    result.IsOk = false;
                    result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS076);
                    result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS076.ToString();
                    return result;
                }
                #endregion

                #region Validation Category Redemption Transaction
                if (requestFeeTax.TransactionCategory.Trim().Equals("RED") && !dataProduct.AllowRedemption)
                {
                    result.IsOk = false;
                    result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS077);
                    result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS077.ToString();
                    return result;
                }
                #endregion

                #region Validation Category Switiching Transaction
                if (requestFeeTax.TransactionCategory.Equals("SWT"))
                {
                    var dataProductTo = await dbContext.Tproducts.Where(x => x.ProductCode.Equals(requestFeeTax.ProductCodeTo.Trim())).FirstOrDefaultAsync();
                    if (dataProductTo == null)
                    {
                        result.IsOk = false;
                        result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS007);
                        result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS007.ToString();
                        return result;
                    }

                    if (!dataProduct.AllowSwitching || !dataProductTo.AllowSwitching)
                    {
                        result.IsOk = false;
                        result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS078);
                        result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS078.ToString();
                        return result;
                    }

                    if (dataProduct.FhId != dataProductTo.FhId)
                    {
                        result.IsOk = false;
                        result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS079);
                        result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS079.ToString();
                        return result;
                    }
                }
                #endregion

                #region Validation NAV
                var getDataNAV = await boReference.GetDataNavByProduct(dataProduct.Idproduct);
                if (getDataNAV == null)
                {
                    result.IsOk = false;
                    result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS081);
                    result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS081.ToString();
                    return result;
                }
                #endregion

                #region Validation Product Bank Account
                if (requestFeeTax.TransactionCategory.Trim().Equals("SUB"))
                    productCategory = new[] { "SUB", "SUBRED" };
                if (requestFeeTax.TransactionCategory.Trim().Equals("RED"))
                    productCategory = new[] { "RED", "SUBRED" };
                if (requestFeeTax.TransactionCategory.Trim().Equals("SWT"))
                    productCategory = new[] { "RED", "SUBRED", "AUTO", "FEE" };

                var productBankAccount = await dbContext.TproductBankAccounts.Where(x => x.Idproduct == dataProduct.Idproduct
                                                          && productCategory.Contains(x.Idcategory))
                                                          .Select(x => new {x.AccountNo, x.IsMandatory}).OrderByDescending(x => x.IsMandatory)
                                                          .FirstOrDefaultAsync();

                if (productBankAccount == null)
                {
                    result.IsOk = false;
                    result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS082);
                    result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS082.ToString();
                    return result;
                }
                #endregion

                foreach (var item in requestFeeTax.transactionValue)
                {
                    double itemUnit;
                    double itemNetAmount = 0;
                    TaxFeeListOut taxFeeListOut = new();

                    if (item.IsRedeemAll == true)
                    {
                        if (!string.IsNullOrEmpty(item.InvAccountNo) && (requestFeeTax.TransactionCategory.Trim().Equals("RED") || requestFeeTax.TransactionCategory.Trim().Equals("SWT")))
                        {
                            var subAccount = await dbContext.TsubAccounts.Where(x => x.NoAccount.Equals(item.InvAccountNo)).FirstOrDefaultAsync();
                            if (subAccount == null)
                            {
                                result.IsOk = false;
                                result.Message = item.InvAccountNo + " " + responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS080);
                                result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS080.ToString();
                                return result;
                            }

                            double redUnit = 0;
                            itemUnit = await boReference.GetBalancePerSubAccount(subAccount.IdsubAccount, DateTime.Now);

                            var getDataHoldUnit = await dbContext.TholdUnits.Where(x => x.Idcustomer == subAccount.Idcustomer && x.IdsubAccount == subAccount.IdsubAccount && x.HoldType == 1).ToListAsync();
                            foreach (var holdUnit in getDataHoldUnit)
                            {
                                var _tHoldunit2 = await dbContext.TholdUnits.Where(x => x.OldTholdUnitId == holdUnit.TholdUnitId).ToListAsync();
                                if (_tHoldunit2.Count == 0)
                                    redUnit += holdUnit.Units ?? 0;
                            }

                            DateTime beginDate, endDate;
                            beginDate = DateTime.Now.AddYears(-100);
                            endDate = DateTime.Now;

                            var transactionRedList = GetTransactionsRedBeforeAppBySubAcc(subAccount.IdsubAccount, subAccount.Idproduct, beginDate, endDate);
                            foreach (var transaction in transactionRedList.Result)
                            {
                                double unit = Convert.ToDouble(transaction.Units);
                                redUnit += unit;
                            }
                            itemUnit -= redUnit;
                        }
                        else itemUnit = item.Units;
                    }
                    else itemUnit = item.Units;

                    if (item.NetAmount > 0) 
                        itemNetAmount = item.NetAmount / 100;

                    if (requestFeeTax.TransactionCategory.Trim().Contains("INST"))
                    {
                        int TRegInvestPlanID = requestFeeTax.TransactionCategory == "INST" ? 1 : 2;
                        var productRegInvestmentPlan = await dbContext.TproductRegInvestmentPlans.
                                                      Where(x => x.Idproduct == dataProduct.Idproduct
                                                      && x.TregularInvestmentPlanId == TRegInvestPlanID
                                                      && x.IsActive == true && x.ChannelId.Equals(Convert.ToInt16(getDataChannel.MainValue))).FirstOrDefaultAsync();

                        if (productRegInvestmentPlan != null)
                        {
                            TregularInvestmentPlanFeeDetail? regularInvestmentPlanFeeDetail = await dbContext.TregularInvestmentPlanFeeDetails.
                                Where(x => x.TregularInvestmentPlanFeeId == productRegInvestmentPlan.TregularInvestmentPlanFeeId && 
                                x.Tenor == requestFeeTax.Tenor && x.MinimumAmount <= item.NetAmount && 
                                (x.MaximumAmount == null ? true : x.MaximumAmount >= item.NetAmount ? true : false)).FirstOrDefaultAsync();

                            if (regularInvestmentPlanFeeDetail != null)
                            {
                                FeePercentage = regularInvestmentPlanFeeDetail.FeePercentage;
                            }
                        }
                    }
                    else
                    {
                        FeePercentage = await GetProductTransactionFeePercent(Convert.ToInt16(getDataChannel.MainValue), requestFeeTax.ProductCode, requestFeeTax.TransactionCategory);
                    }

                    FeePercentage /= 100.0;

                    if (requestFeeTax.TransactionCategory.Trim().Equals("SWTOT") || requestFeeTax.TransactionCategory.Trim().Equals("SWT"))
                    {
                        taxFeeListOut.NetAmount = itemUnit * NAV;
                        taxFeeListOut.FeeAmount = taxFeeListOut.NetAmount * FeePercentage;
                        taxFeeListOut.TaxAmount = taxFeeListOut.FeeAmount * double.Parse(tconfigTranFeeTaxValue.Value);
                        taxFeeListOut.Amount = Math.Round(taxFeeListOut.FeeAmount,2) + Math.Round(taxFeeListOut.TaxAmount,2);
                    }

                    if (requestFeeTax.TransactionCategory.Trim().Equals("SUB") || requestFeeTax.TransactionCategory.Trim().Contains("INST"))
                    {
                        taxFeeListOut.NetAmount = itemNetAmount;
                        taxFeeListOut.FeeAmount = taxFeeListOut.NetAmount * FeePercentage;
                        taxFeeListOut.TaxAmount = taxFeeListOut.FeeAmount * double.Parse(tconfigTranFeeTaxValue.Value);
                        taxFeeListOut.Amount = Math.Round(taxFeeListOut.NetAmount, 2) + Math.Round(taxFeeListOut.FeeAmount, 2) + Math.Round(taxFeeListOut.TaxAmount, 2);
                    }

                    taxFeeListOut.InvAccountNo = item.InvAccountNo;
                    taxFeeListOut.Amount = BuildAmount(taxFeeListOut.Amount, 2);
                    taxFeeListOut.NetAmount = BuildAmount(taxFeeListOut.NetAmount, 2);
                    taxFeeListOut.FeePercentage = BuildAmount(FeePercentage, 2);
                    taxFeeListOut.FeeAmount = BuildAmount(taxFeeListOut.FeeAmount, 2);
                    taxFeeListOut.TaxPercentage = double.Parse(tconfigTranFeeTaxValue.Value);
                    taxFeeListOut.TaxAmount = BuildAmount(taxFeeListOut.TaxAmount, 2);

                    result.Data.TotalNetAmount += taxFeeListOut.NetAmount;
                    result.Data.TotalAmount += taxFeeListOut.Amount;
                    result.Data.TotalTaxAmount += taxFeeListOut.TaxAmount;
                    result.Data.TotalFeeAmount += taxFeeListOut.FeeAmount;
                    
                    result.Data.TaxFeeListOut.Add(taxFeeListOut);
                }

                #endregion

                result.Data.CIF = requestFeeTax.CIF;
                result.Data.ProductCode = requestFeeTax.ProductCode;
                result.Data.TransactionCategory = requestFeeTax.TransactionCategory;
                result.Data.NAVPerUnit = getDataNAV.Value;
                result.Data.NAVDate = getDataNAV.Navdate;
                result.Data.Currency = strcurrencyCode;
                result.Data.ProdBankAccountNo = productBankAccount.AccountNo;
                result.Data.ProductCodeTo = requestFeeTax.ProductCodeTo;
                result.Data.IsAfter = IsAfter;
            }
            catch (Exception ex)
            {
                result.IsOk = false;
                result.Message = ex.Message;
                result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS999.ToString();
                
            }
            finally
            {
                await boLogger.SaveLog("IN", requestFeeTax.ChannelID.Trim(), "Service Inquiry Fee Tax", "InqFeeTax", "", null,
                                    requestFeeTax.CIF.Trim(), JsonConvert.SerializeObject(requestFeeTax), JsonConvert.SerializeObject(result), result.ResponseCode,
                                    result.Message, result.Message, requestFeeTax.ChannelID.Trim(), DateTime.Now);
            }
            return result;
        }
        public double BuildAmount(double value, int digit)
        {
            double _Digit = Convert.ToDouble("1".ToString().PadRight(digit + 1, '0'));
            return Math.Round((Math.Round(value, digit) * _Digit));
        }
        public async Task<List<Ttransaction>> GetTransactionsRedBeforeAppBySubAcc(long iDSubAccount, long iDProduct, DateTime beginDate, DateTime endDate)
        {
            string[] category = { "SWTOT", "RED", "TROUT", "ADJDN" };
            string[] status = { "ENTRIED", "VERIFIED", "CORRECTED", "GOODFUND", "TOBECORRECTED", "UNGOODFUND", "TBCRCTD" };

            List<Ttransaction> trxList = await dbContext.Ttransactions.Where(x => x.IdsubAccount == iDSubAccount && x.Idproduct == iDProduct && status.Contains(x.Idstatus)
                                           && category.Contains(x.Idcategory)
                                           && DateTime.Compare((DateTime)x.Navdate, beginDate) <= 0
                                           && DateTime.Compare((DateTime)x.Navdate, endDate) >= 0).ToListAsync();

            return trxList;
        }
        public async ValueTask<double> GetDataNAV(long idProduct)
        {
            double Nav = 0;
            var getNav = await dbContext.Tnavs.OrderByDescending(x => x.Navdate).Where(y => y.Idproduct == idProduct && y.Navdate <= DateTime.Now).FirstOrDefaultAsync();
            Nav = getNav.Value;

            return Nav;
        }
        public async ValueTask<double> GetProductTransactionFeePercent (short channelID, string productCode, string transactionCategory)
        {
            double feePercent = 0;
           
            var result_ = await (from pf in dbContext.TproductTransactionFees
                           join p in dbContext.Tproducts on pf.Idproduct equals p.Idproduct
                           join ttf in dbContext.TtransactionFeeDetails on pf.TtransactionFeeId equals ttf.TtransactionFeeId
                           where pf.ChannelId == channelID && pf.TrxIdcategory == transactionCategory && p.ProductCode == productCode
                           select new { fee = ttf.FeePercentage ?? 0 }).FirstOrDefaultAsync();

            if (result_ == null)
            {
                if (transactionCategory == "SWT")
                {
                    result_ = await (from pf in dbContext.TproductTransactionFees
                               join p in dbContext.Tproducts on pf.Idproduct equals p.Idproduct
                               join ttf in dbContext.TtransactionFeeDetails on pf.TtransactionFeeId equals ttf.TtransactionFeeId
                               where pf.ChannelId == channelID && pf.TrxIdcategory == "SWTOT" && p.ProductCode == productCode
                               select new { fee = ttf.FeePercentage ?? 0 }).FirstOrDefaultAsync();

                    if (result_ == null)
                        feePercent = 0;
                    else
                        feePercent = Convert.ToDouble(result_.fee);
                }
                else
                    feePercent = 0;
            }
            else
                feePercent = Convert.ToDouble(result_.fee);

            return feePercent;
        }
    }
}