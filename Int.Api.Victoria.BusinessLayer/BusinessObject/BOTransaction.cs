using Int.Api.Victoria.BusinessLayer.BindingModel;
using Int.Api.Victoria.BusinessLayer.BindingModelResult;
using Int.Api.Victoria.BusinessLayer.BusinessObject.Master;
using Int.Api.Victoria.BusinessLayer.Custom;
using Int.Api.Victoria.BusinessLayer.Interface;
using Int.Api.Victoria.DataAccess.Context;
using Int.Api.Victoria.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace Int.Api.Victoria.BusinessLayer.BusinessObject
{
    public class BOTransaction : IBOTransactions
    {
        private readonly DBContext dbContext;
        private readonly Reference boReference;
        private readonly ResponseCode.ResponseCode responseCode;
        private readonly CustomFunction customFunction;
        private readonly BOLogger boLogger;
        public Holiday holiday;
        public BOTransaction(DBContext db)
        {
            dbContext = db;
            boReference = new Reference(dbContext);
            responseCode = new();
            holiday = new(dbContext);
            customFunction = new();
            boLogger = new(db);
        }
        public async Task<ResultBase<BMRTransaction>> ProcessTransactions(BMTransaction requestTransaction)
        {
            var result = new ResultBase<BMRTransaction>
            {
                Data = new()
            };

            //bool isHoliday = false;
            DateTime _date = DateTime.Now;

            Ttransaction TTransactions = new();
            Ttransaction TTransactionsIn = new();
            Tproduct? resultDataProductTo = new();

            long tempIDTransaction = 0;

            string[] iDCategorySUB = { "SUB", "SUBRED" };
            string[] iDCategoryRED = { "RED", "SUBRED" };
            string[] iDCategorySWT = { "RED", "SUBRED", "AUTO", "FEE" };

            try
            {
                #region Validation Check Data Channel
                VTreferenceDetail? resultDataChannel = await boReference.GetChannel(requestTransaction.ChannelID.Trim());
                if (resultDataChannel == null)
                {
                    result.IsOk = false;
                    result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS018);
                    result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS018.ToString();
                    return result;
                }
                #endregion

                #region Validation Check Data CIF
                Tcustomer? resultDataCustomer = await boReference.GetCustomerByCif(requestTransaction.CIF.Trim());
                if (resultDataCustomer == null)
                {
                    result.IsOk = false;
                    result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS006);
                    result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS006.ToString();
                    return result;
                }
                #endregion

                #region Validation Check Data Product Code
                Tproduct? resultDataProduct = await boReference.GetProductByProductcode(requestTransaction.ProductCode.Trim());
                if (resultDataProduct == null)
                {
                    result.IsOk = false;
                    result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS007);
                    result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS007.ToString();
                    return result;
                }

                if (resultDataProduct.Idmftype.Equals("OPEN"))
                {
                    switch (requestTransaction.TransactionCategory.ToUpper().Trim())
                    {
                        case "SUB":
                            if (!resultDataProduct.AllowSubscription)
                            {
                                result.IsOk = false;
                                result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS063);
                                result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS063.ToString();
                                return result;
                            }
                            break;

                        case "RED":
                            if (!resultDataProduct.AllowRedemption)
                            {
                                result.IsOk = false;
                                result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS064);
                                result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS064.ToString();
                                return result;
                            }
                            break;

                        case "SWT":
                            if (!resultDataProduct.AllowSwitching)
                            {
                                result.IsOk = false;
                                result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS078);
                                result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS078.ToString();
                                return result;
                            }
                            break;
                    }
                }
                else
                {
                    result.IsOk = false;
                    result.Message = "Product Code " + responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS104);
                    result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS104.ToString();
                    return result;
                }
                #endregion

                #region Validation Check Data Generator ID
                short resultGeneratorID = await boReference.GetTransactionGenerator(requestTransaction.ChannelID.Trim());
                if (resultGeneratorID == 0)
                {
                    result.IsOk = false;
                    result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS010);
                    result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS010.ToString();
                    return result;
                }
                #endregion

                #region Validation Request Transaction SWT
                if (requestTransaction.TransactionCategory.Trim().Equals("SWT") && string.IsNullOrEmpty(requestTransaction.ProductCodeTo))
                {
                    result.IsOk = false;
                    result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS073);
                    result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS073.ToString();
                    return result;
                }

                if (requestTransaction.TransactionCategory.Equals("SWT"))
                {
                    resultDataProductTo = await dbContext.Tproducts.Where(x => x.ProductCode.Equals(requestTransaction.ProductCodeTo.Trim())).FirstOrDefaultAsync();
                    if (resultDataProductTo == null)
                    {
                        result.IsOk = false;
                        result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS007);
                        result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS007.ToString();
                        return result;
                    }
                    if (resultDataProductTo.Idmftype.Equals("OPEN"))
                    {
                        if (!resultDataProduct.AllowSwitching || !resultDataProductTo.AllowSwitching)
                        {
                            result.IsOk = false;
                            result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS078);
                            result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS078.ToString();
                            return result;
                        }

                        if (resultDataProduct.FhId != resultDataProductTo.FhId)
                        {
                            result.IsOk = false;
                            result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS079);
                            result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS079.ToString();
                            return result;
                        }
                    }
                    else
                    {
                        result.IsOk = false;
                        result.Message = "Product Code To " + responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS104);
                        result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS104.ToString();
                        return result;
                    }
                }
                #endregion

                #region Process Data Transaction

                #region Check Cut Off Time Entry Transaction SUB, RED
                Tconfig? tConfig = new();
                switch (requestTransaction.TransactionCategory.ToUpper().Trim())
                {
                    case "SUB":
                        tConfig = await boReference.GetConfigByKey(requestTransaction.ChannelID.Trim() + ".Transaction.Sub.Entry.CutOffTime");
                        break;

                    case "RED":
                        tConfig = await boReference.GetConfigByKey(requestTransaction.ChannelID.Trim() + ".Transaction.Red.Entry.CutOffTime");
                        break;

                    case "SWT":
                        tConfig = await boReference.GetConfigByKey(requestTransaction.ChannelID.Trim() + ".Transaction.Swt.Entry.CutOffTime");
                        break;
                }
                if (tConfig is null)
                {
                    result.IsOk = false;
                    result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS008);
                    result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS008.ToString();
                    return result;
                }
                #endregion

                DateTime vTransactionDate;
                DateTime vNavDate;
                DateTime vSettDate;

                vTransactionDate = _date;
                vNavDate = _date;
                vSettDate = holiday.AddDate(vNavDate, resultDataProduct.SubSettle, resultDataProduct.Idcurrency);
                bool isHoliday = await holiday.IsHoliday(_date, resultDataProduct.Idcurrency);

                if (isHoliday ||
                                    (Convert.ToDateTime(tConfig.Value).TimeOfDay.Hours < _date.TimeOfDay.Hours) ||
                                    (Convert.ToDateTime(tConfig.Value).TimeOfDay.Hours == _date.TimeOfDay.Hours &&
                                        Convert.ToDateTime(tConfig.Value).TimeOfDay.Minutes < _date.TimeOfDay.Minutes)
                                    )
                {
                    vNavDate = holiday.AddDate(vTransactionDate, 1, resultDataProduct.Idcurrency);
                    vSettDate = holiday.AddDate(vNavDate, resultDataProduct.SubSettle, resultDataProduct.Idcurrency);
                }

                TproductBankAccount? tproductBankAccount = new();
                switch (requestTransaction.TransactionCategory.ToUpper().Trim())
                {
                    case "SUB":
                        tproductBankAccount = await boReference.GetTproductBankAccountByCategory(resultDataProduct.Idproduct, iDCategorySUB);
                        break;

                    case "RED":
                        tproductBankAccount = await boReference.GetTproductBankAccountByCategory(resultDataProduct.Idproduct, iDCategoryRED);
                        break;

                    case "SWT":
                        tproductBankAccount = await boReference.GetTproductBankAccountByCategory(resultDataProduct.Idproduct, iDCategorySWT);
                        break;
                }

                if (tproductBankAccount is null)
                {
                    result.IsOk = false;
                    result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS009);
                    result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS009.ToString();
                    return result;
                }

                if (tproductBankAccount is not null)
                {
                    double _TaxPercent = 0;
                    Tconfig? tconfigTax = await boReference.GetConfigByKey("UI.Transaction.Fee.Tax");
                    _TaxPercent = double.Parse(tconfigTax.Value);

                    #region Get Fee Percentage
                    double? _FeePercent = 0;
                    _FeePercent = await boReference.GetTransactionFee(short.Parse(resultDataChannel.MainValue), resultDataProduct.ProductCode, requestTransaction.TransactionCategory.ToUpper().Trim(), vTransactionDate);
                    #endregion

                    foreach (var item in requestTransaction.TransAccountLists)
                    {
                        TsubAccount? tsubAccount = new();
                        tsubAccount = await boReference.GetDataSubAccount(resultDataCustomer.Idcustomer, resultDataProduct.Idproduct);

                        if (string.IsNullOrEmpty(item.InAccountNo) && requestTransaction.TransactionCategory.Trim().ToUpper().Equals("SUB")
                                            && tsubAccount == null
                                            )
                        {
                            TsubAccount tsubAccountNew = new()
                            {
                                NoAccount = resultDataCustomer.UnitHolderIdno + " " + resultDataProduct.Idproduct.ToString() + " REGULER",
                                Idcustomer = resultDataCustomer.Idcustomer,
                                Idproduct = resultDataProduct.Idproduct,
                                CreatedBy = "System",
                                CreatedDate = DateTime.Now,
                                SubAccountType = 1
                            };

                            await dbContext.TsubAccounts.AddAsync(tsubAccountNew);
                            await dbContext.SaveChangesAsync();
                        }

                        if (!string.IsNullOrEmpty(item.InAccountNo) && (requestTransaction.TransactionCategory.Trim().Equals("RED") || requestTransaction.TransactionCategory.Trim().Equals("SWT")))
                        {
                            tsubAccount = await dbContext.TsubAccounts.Where(x => x.NoAccount.Equals(item.InAccountNo)).FirstOrDefaultAsync();
                        }

                        if (requestTransaction.TransactionCategory.Trim().Equals("SUB"))
                        {
                            if (tsubAccount is null)
                                tsubAccount = await boReference.GetDataSubAccount(resultDataCustomer.Idcustomer, resultDataProduct.Idproduct);
                        }

                        if (tsubAccount is not null)
                        {
                            TcustBankAccount? tcustBankAccount = new();
                            if (requestTransaction.TransactionCategory.Trim().ToUpper().Equals("SUB"))
                            {
                                tcustBankAccount = await boReference.GetTcustBankAccount(resultDataProduct.Idcurrency, resultDataCustomer.Idcustomer);
                            }
                            if (requestTransaction.TransactionCategory.Trim().ToUpper().Equals("RED"))
                            {
                                tcustBankAccount = await boReference.GetTcustBankAccountRED(requestTransaction.CustAccountNo, resultDataCustomer.Idcustomer);
                            }

                            if (tcustBankAccount is not null)
                            {
                                TcustomerRiskProfile? tcustomerRiskProfile = new();
                                if (requestTransaction.TransactionCategory.Trim().ToUpper().Equals("SUB"))
                                {
                                    tcustomerRiskProfile = await boReference.GetTcustomerRiskProfile(resultDataCustomer.Idcustomer, _date);
                                    if (tcustomerRiskProfile is null)
                                    {
                                        result.IsOk = false;
                                        result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS017);
                                        result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS017.ToString();
                                        return result;
                                    }

                                    TcustomerProductRiskProfileMapping? tcustomerProductRiskProfileMapping = await boReference.GetTcustomerProductRiskProfileMapping(tcustomerRiskProfile.ProfileId, resultDataProduct.ProfileId);
                                    if (tcustomerProductRiskProfileMapping is null)
                                    {
                                        result.IsOk = false;
                                        result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS019);
                                        result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS019.ToString();
                                        return result;
                                    }

                                    if (tcustomerProductRiskProfileMapping != null && tcustomerProductRiskProfileMapping.IsWarning)
                                    {
                                        result.IsOk = false;
                                        result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS020);
                                        result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS020.ToString();
                                        return result;
                                    }
                                }
                                double tempOutstandingBalanceUnit = 0;
                                //validasi trx red & swt
                                if (requestTransaction.TransactionCategory.Trim().Equals("RED") || requestTransaction.TransactionCategory.Trim().Equals("SWT"))
                                {
                                    var OutStandingsBalanceUnit = await boReference.GetBalancePerSubAccount(tsubAccount.IdsubAccount, vTransactionDate);

                                    if (!item.IsRedeemAll)
                                    {
                                        if (OutStandingsBalanceUnit is 0)
                                        {
                                            result.IsOk = false;
                                            result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS052);
                                            result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS052.ToString();
                                            return result;
                                        }

                                        if ((OutStandingsBalanceUnit - item.Units) < resultDataProduct.MinBalanceAfterRedemption)
                                        {
                                            result.IsOk = false;
                                            result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS025);
                                            result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS025.ToString();
                                            return result;
                                        }
                                    }

                                    if (item.IsRedeemAll)
                                    {
                                        DateTime _BeginDate, _EndDate;
                                        _BeginDate = holiday.AddDate(DateTime.Now, -1, resultDataProduct.Idcurrency);
                                        _EndDate = DateTime.Now;

                                        var trxRedList = await boReference.GetTransactionsRedBeforeAppBySubAcc(tsubAccount.IdsubAccount, resultDataProduct.Idproduct, _BeginDate, _EndDate);
                                        double units = 0;

                                        foreach (var itemRed in trxRedList)
                                        {
                                            units += Convert.ToDouble(itemRed.Units);
                                        }

                                        item.Units = (double)OutStandingsBalanceUnit - units;

                                        if (item.Units <= 0)
                                        {
                                            result.IsOk = false;
                                            result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS026);
                                            result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS026.ToString();
                                            return result;
                                        }
                                    }
                                    tempOutstandingBalanceUnit = OutStandingsBalanceUnit;
                                }
                                
                                Tagent? tagent = await boReference.GetDataAgent(requestTransaction.ChannelID.Trim());
                                if (tagent is not null)
                                {
                                    //create transaction
                                    if (requestTransaction.TransactionCategory.ToUpper().Trim().Equals("SWT"))
                                    {
                                        TTransactions.Units = item.Units;
                                        TTransactions.NetAmount = item.Units;
                                        TTransactions.FeeAmount = (_FeePercent / 100) * TTransactions.NetAmount;
                                        TTransactions.FeeTax = (_TaxPercent) * TTransactions.FeeAmount;
                                        TTransactions.Amount = TTransactions.FeeAmount + TTransactions.FeeTax;
                                        TTransactions.InputMode = 1;
                                        if (tempOutstandingBalanceUnit <= item.Units)
                                            TTransactions.IsRedemAll = true;

                                        // Transaction Switching In
                                        TproductBankAccount? tProductBankAccountIn = new();
                                        tProductBankAccountIn = await boReference.GetTproductBankAccountByCategory(resultDataProductTo.Idproduct, iDCategorySWT);
                                        if (!string.IsNullOrWhiteSpace(tProductBankAccountIn?.AccountNo))
                                        {
                                            TsubAccount? tsubAccountIn = new();
                                            tsubAccountIn = await boReference.GetDataSubAccount(tsubAccount.Idcustomer, resultDataProductTo.Idproduct);

                                            if (tsubAccountIn is not null)
                                            {
                                                TTransactionsIn.IdsubAccount = tsubAccountIn.IdsubAccount;
                                            }
                                            else
                                            {
                                                TsubAccount tsubAccountNew = new()
                                                {
                                                    NoAccount = resultDataCustomer.UnitHolderIdno + " " + resultDataProduct.Idproduct.ToString() + " REGULER",
                                                    Idcustomer = resultDataCustomer.Idcustomer,
                                                    Idproduct = resultDataProductTo.Idproduct,
                                                    CreatedBy = "System",
                                                    CreatedDate = DateTime.Now,
                                                    SubAccountType = 1
                                                };

                                                await dbContext.TsubAccounts.AddAsync(tsubAccountNew);
                                                await dbContext.SaveChangesAsync();
                                            }

                                            TTransactionsIn.Idcustomer = resultDataCustomer.Idcustomer;
                                            TTransactionsIn.Idproduct = resultDataProductTo.Idproduct;
                                            TTransactionsIn.Amount = 0;
                                            TTransactionsIn.NetAmount = 0;
                                            TTransactionsIn.FeeAmount = 0;
                                            TTransactionsIn.SwitchingPercent = 100;
                                            TTransactionsIn.Idcategory = "SWTIN";
                                            TTransactionsIn.Idstatus = "VERIFIED";
                                            TTransactionsIn.ReferenceNo = requestTransaction.RefNo;
                                            TTransactionsIn.Idsales = tagent.AgentId;
                                            TTransactionsIn.TransactionDate = vTransactionDate;
                                            TTransactionsIn.Navdate = vNavDate;
                                            TTransactionsIn.SettDate = vSettDate;
                                            TTransactionsIn.Fee = 0;//_FeePercent;
                                            TTransactionsIn.GeneratorId = resultGeneratorID;
                                            //transactionIn.GeneratorData2 = GLReconNo;
                                            TTransactionsIn.ProductProfileId = resultDataProductTo.ProfileId;
                                            TTransactionsIn.CustomerProfileId = tcustomerRiskProfile.ProfileId;
                                            TTransactionsIn.InputMode = 1; // UNIT -> TRefTransactionInputMode
                                            TTransactionsIn.EntryDate = DateTime.Now;
                                            TTransactionsIn.EntryUser = requestTransaction.ChannelID.Trim();
                                            TTransactionsIn.VerifyTime = DateTime.Now;
                                            TTransactionsIn.VerifyUser = requestTransaction.ChannelID.Trim();
                                            TTransactionsIn.SubscriptionFeeMethod = "NETT";
                                            TTransactionsIn.TtransactionBankAccounts.Add(new TtransactionBankAccount()
                                            {
                                                //Product Bank Account
                                                AccountName = tProductBankAccountIn.AccountName,
                                                AccountNo = tProductBankAccountIn.AccountNo,
                                                IdbankBranch = tProductBankAccountIn.IdbankBranch,
                                                Idcurrency = tProductBankAccountIn.Idcurrency,
                                                TransAccountType = 1
                                            });
                                        }
                                    }

                                    if (requestTransaction.TransactionCategory.ToUpper().Trim().Equals("RED"))
                                    {
                                        TTransactions.Units = item.Units;
                                        TTransactions.IsRedemAll = item.IsRedeemAll;

                                        double? _FeeUnit = (_FeePercent / 100) * Convert.ToDouble(item.Units);

                                        TTransactions.FeeUnit = _FeeUnit;
                                        TTransactions.InputMode = 1 /*Unit -> TRefTransactionInputMode*/;
                                    }

                                    if (requestTransaction.TransactionCategory.ToUpper().Trim().Equals("SUB"))
                                    {
                                        double? _FeeAmount = (_FeePercent / 100) * Convert.ToDouble(item.NetAmount);
                                        double? _TaxAmount = (_TaxPercent) * _FeeAmount;

                                        TTransactions.InputMode = 3 /*Net Amount -> TRefTransactionInputMode*/;
                                        TTransactions.SubscriptionFeeMethod = "NETT";
                                        TTransactions.Amount = item.NetAmount + _FeeAmount + _TaxAmount;
                                        TTransactions.NetAmount = item.NetAmount;
                                        TTransactions.FeeAmount = _FeeAmount;
                                        TTransactions.FeeTax = _TaxAmount;
                                    }

                                    if (requestTransaction.TransactionCategory.ToUpper().Trim().Equals("SWT"))
                                        TTransactions.Idcategory = "SWTOT";
                                    else
                                        TTransactions.Idcategory = requestTransaction.TransactionCategory.Trim();

                                    TTransactions.Idstatus = "ENTRIED";
                                    TTransactions.ReferenceNo = requestTransaction.RefNo;
                                    TTransactions.IdsubAccount = tsubAccount.IdsubAccount;
                                    TTransactions.Idcustomer = resultDataCustomer.Idcustomer;
                                    TTransactions.Idproduct = resultDataProduct.Idproduct;
                                    TTransactions.Idsales = tagent.AgentId;
                                    TTransactions.TransactionDate = vTransactionDate;
                                    TTransactions.Navdate = vNavDate;
                                    TTransactions.SettDate = vSettDate;
                                    TTransactions.Fee = _FeePercent;
                                    TTransactions.GeneratorId = resultGeneratorID;
                                    TTransactions.ProductProfileId = resultDataProduct.ProfileId;
                                    TTransactions.CustomerProfileId = tcustomerRiskProfile.ProfileId;
                                    TTransactions.EntryDate = _date;
                                    TTransactions.EntryUser = requestTransaction.ChannelID.Trim();
                                    TTransactions.Remark = requestTransaction.Remark.Trim();

                                    short _transAccount = 3;
                                    if (requestTransaction.TransactionCategory.ToUpper().Trim().Equals("SWT"))
                                        _transAccount = 4;

                                    TTransactions.TtransactionBankAccounts.Add(new TtransactionBankAccount
                                    {
                                        //Customer Bank Account
                                        AccountName = tcustBankAccount.AccountName,
                                        AccountNo = tcustBankAccount.AccountNo,
                                        IdbankBranch = tcustBankAccount.IdbankBranch,
                                        Idcurrency = tcustBankAccount.Idcurrency,
                                        TransAccountType = _transAccount
                                    });
                                    TTransactions.TtransactionBankAccounts.Add(new TtransactionBankAccount
                                    {
                                        //Product Bank Account
                                        AccountName = tproductBankAccount.AccountName,
                                        AccountNo = tproductBankAccount.AccountNo,
                                        IdbankBranch = tproductBankAccount.IdbankBranch,
                                        Idcurrency = tproductBankAccount.Idcurrency,
                                        TransAccountType = 1
                                    });

                                    var (savetrx, idtrx) = await InsertTransactionData(TTransactions);
                                    try
                                    {
                                        if (savetrx)
                                        {
                                            TtransactionNotification ttransactionNotification = new TtransactionNotification()
                                            {
                                                CreatedOnPageAccessStatusId = 0,
                                                Idtransaction = idtrx,
                                                Message = "",
                                                NewIdstatus = "ENTRIED",
                                                SysCreatedBy = requestTransaction.ChannelID.Trim(),
                                                SysCreatedTime = DateTime.Now,
                                                SysCreatedHost = requestTransaction.ChannelID.Trim()
                                            };

                                            var trxNotif = await InsertTtransactionNotification(ttransactionNotification);
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        result.IsOk = false;
                                        result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS015);
                                        result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS015.ToString();
                                        return result;
                                    }

                                    if (savetrx)
                                    {
                                        //Set return value
                                        tempIDTransaction = idtrx;
                                        result.Data.CIF = requestTransaction.CIF;
                                        result.Data.ProductCode = resultDataProduct.ProductCode;
                                        result.Data.TransactionCategory = TTransactions.Idcategory;
                                        result.Data.TransactionDate = customFunction.ConvertDateToStringFormatESB((DateTime)TTransactions.TransactionDate);
                                        result.Data.SettlementDate = customFunction.ConvertDateToStringFormatESB((DateTime)TTransactions.SettDate);
                                        result.Data.NAVDate = customFunction.ConvertDateToStringFormatESB((DateTime)TTransactions.Navdate);
                                        result.Data.CustBankAccountNo = TTransactions.AccountNoCustomer;
                                        result.Data.ProductCodeTo = requestTransaction.ProductCodeTo;
                                        result.Data.CustBankAccountNo = tcustBankAccount.AccountNo;
                                        result.Data.ProdBankAccountNo = tproductBankAccount.AccountNo;

                                        if (requestTransaction.TransactionCategory.Trim().Equals("SWT"))
                                        {
                                            TTransactionsIn.SourceIdtransaction = idtrx;
                                            TTransactionsIn.TtransactionBankAccounts.Add(new TtransactionBankAccount()
                                            {
                                                //Customer Bank Account
                                                AccountName = tcustBankAccount.AccountName,
                                                AccountNo = tcustBankAccount.AccountNo,
                                                IdbankBranch = tcustBankAccount.IdbankBranch,
                                                Idcurrency = tcustBankAccount.Idcurrency,
                                                TransAccountType = _transAccount
                                            });

                                            var (savetrxin, idtrxin) = await InsertTransactionData(TTransactionsIn);
                                            if (savetrxin)
                                            {
                                                result.Data.TransactionLists = new List<TransactionList>();
                                                TransactionList transactionInItem = new()
                                                {
                                                    Amount = 0,
                                                    Charges = 0,
                                                    FeeAmount = 0,
                                                    NetAmount = 0,
                                                    TaxAmount = 0,
                                                    Remark = TTransactions.Remark,
                                                    RefNo = TTransactions.ReferenceNo,
                                                    TransactionID = idtrxin
                                                };
                                                result.Data.TransactionLists.Add(transactionInItem);
                                                return result;
                                            }
                                        }

                                        result.Data.TransactionLists = new List<TransactionList>();
                                        TransactionList transactionItem = new()
                                        {
                                            Amount = TTransactions.Amount == null ? 0 : (double)TTransactions.Amount,
                                            NetAmount = TTransactions.NetAmount == null ? 0 : (double)TTransactions.NetAmount,
                                            FeeAmount = TTransactions.FeeAmount == null ? 0 : (double)TTransactions.FeeAmount,
                                            TaxAmount = TTransactions.FeeTax == null ? 0 : (double)TTransactions.FeeTax,
                                            Charges = TTransactions.Charges == null ? 0 : (double)TTransactions.Charges,
                                            Remark = TTransactions.Remark,
                                            RefNo = TTransactions.ReferenceNo,
                                            IsRedeemAll = TTransactions.IsRedemAll,
                                            TransactionID = idtrx
                                        };
                                        result.Data.TransactionLists.Add(transactionItem);
                                    }
                                    else
                                    {
                                        result.IsOk = false;
                                        result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS015);
                                        result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS015.ToString();
                                        return result;
                                    }
                                }
                                else
                                {
                                    result.IsOk = false;
                                    result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS016);
                                    result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS016.ToString();
                                    return result;
                                }
                            }
                        }
                    }
                }

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
                await boLogger.SaveLog("IN", requestTransaction.ChannelID.Trim(), "Service Transaction", "Transaction", "", tempIDTransaction,
                                    requestTransaction.CIF.Trim(), JsonConvert.SerializeObject(requestTransaction), JsonConvert.SerializeObject(result), result.ResponseCode,
                                    result.Message, result.Message, requestTransaction.ChannelID.Trim(), DateTime.Now);
            }

            return result;
        }
        public async Task<(bool, long)> InsertTransactionData(Ttransaction ttransaction)
        {
            try
            {
                await dbContext.Ttransactions.AddAsync(ttransaction);
                await dbContext.SaveChangesAsync();

                return (true, ttransaction.Idtransaction);
            }
            catch (Exception ex)
            {
                return (false, 0);
            }
        }
        public async Task<bool> InsertTtransactionNotification(TtransactionNotification ttransactionNotification)
        {
            try
            {
                await dbContext.TtransactionNotifications.AddAsync(ttransactionNotification);
                await dbContext.SaveChangesAsync();

                return (true);
            }
            catch (Exception ex)
            {
                return (false);
            }
        }
    }
}
