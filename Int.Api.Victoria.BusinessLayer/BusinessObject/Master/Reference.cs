using Int.Api.Victoria.BusinessLayer.BindingModelResult;
using Int.Api.Victoria.BusinessLayer.BusinessObject.InterfaceMaster;
using Int.Api.Victoria.DataAccess.Context;
using Int.Api.Victoria.DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace Int.Api.Victoria.BusinessLayer.BusinessObject.Master
{
    public class Reference : IReference
    {
        private readonly DBContext context;
        public Reference(DBContext dB)
        {
            context = dB;
        }
        public async Task<VTreferenceDetail?> GetChannel(string channelName)
        {
            try
            {
                VTreferenceDetail? vTreferenceDetail = await context.VTreferenceDetails.Where(x => x.GroupName.Equals("TRefTransactionGenerator")
                                                      && x.Display.Equals(channelName)).FirstOrDefaultAsync();

                return vTreferenceDetail;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public async Task<List<VTreferenceDetail>> GetReferenceByGroupname(string groupname)
        {
            try
            {
                List<VTreferenceDetail> vTrefDetail = await (from tref in context.TreferenceDetails.AsNoTracking()
                                               join trefg in context.TreferenceGroups.AsNoTracking()
                                               on tref.TreferenceGroupId equals trefg.TreferenceGroupId
                                               where trefg.GroupName.Equals(groupname)
                                               select new VTreferenceDetail()
                                               {
                                                   GroupName = trefg.GroupName,
                                                   TreferenceDetailId = tref.TreferenceDetailId,
                                                   TreferenceGroupId = tref.TreferenceGroupId,
                                                    MainValue = tref.MainValue,
                                                    AltValue1 = tref.AltValue1,
                                                    AltValue2 = tref.AltValue2,
                                                    AltValue3 = tref.AltValue3,
                                                    AltValue4 = tref.AltValue4,
                                                    AltValue5 = tref.AltValue5,
                                                    AltValue6 = tref.AltValue6,
                                                    Display = tref.Display,
                                                    DisplayOrder = tref.DisplayOrder,
                                                    DisplayId = tref.DisplayId,
                                                    DisplayOrderId = tref.DisplayOrderId,
                                                    DisplayEn = tref.DisplayEn,
                                                    DisplayOrderEn = tref.DisplayOrderEn,
                                                    Remarks = tref.Remarks,
                                                    SysCreatedBy = tref.SysCreatedBy,
                                                    SysCreatedTime = tref.SysCreatedTime,
                                                    SysCreatedHost = tref.SysCreatedHost,
                                                    SysModifiedBy = tref.SysModifiedBy,
                                                    SysModifiedTime = tref.SysModifiedTime,
                                                    SysModifiedHost = tref.SysModifiedHost,
                                                    SysApprovalStatus = tref.SysApprovalStatus,
                                                    SysActionType = tref.SysActionType,
                                                    SysRecStatus = (bool)tref.SysRecStatus,
                                                    SysPendingBy = tref.SysPendingBy,
                                                    SysPendingTime = tref.SysPendingTime,
                                                    SysPendingHost = tref.SysPendingHost,
                                                    SysApprovalNotes = tref.SysApprovalNotes,
                                                    SysApprovedBy = tref.SysApprovedBy,
                                                    SysApprovedTime = tref.SysApprovedTime,
                                                    SysApprovedHost = tref.SysApprovedHost,
                                                    SysDeletedBy = tref.SysDeletedBy,
                                                    SysDeletedTime = tref.SysDeletedTime,
                                                    SysDeletedHost = tref.SysDeletedHost
                                               }).ToListAsync();                

                return vTrefDetail;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public async Task<Tcustomer?> GetCustomerByCif(string CIF)
        {
            try
            {
                Tcustomer? tCustomer = await context.Tcustomers.Where(x => x.UnitHolderIdno.Equals(CIF)).FirstOrDefaultAsync();

                return tCustomer;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public async Task<Tcustomer?> GetDataCustomer(string CIF, string idNumber, string channelID)
        {
            Tcustomer? dataCustomer = await context.Tcustomers.Where(x => (x.UnitHolderIdno.Equals(CIF)
                                                                    || x.Idnumber.Equals(idNumber))
                                                                    && x.SysCreatedBy.Equals(channelID)).FirstOrDefaultAsync();
            return dataCustomer;
        }
        public async Task<Tconfig?> GetConfigByKey(string key)
        {
            try
            {
                Tconfig? tConfig = await context.Tconfigs.Where(x => x.Key.Equals(key)).FirstOrDefaultAsync();
                return tConfig;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public async Task<Tproduct?> GetProductByProductcode(string productCode)
        {
            try
            {
                Tproduct? tproduct = await context.Tproducts.Where(x => x.ProductCode.Equals(productCode)).FirstOrDefaultAsync();
                return tproduct;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public async Task<Tproduct?> GetProductByIdProduct(long idProduct)
        {
            try
            {
                Tproduct? tproduct = await context.Tproducts.Where(x => x.Idproduct == idProduct).FirstOrDefaultAsync();
                return tproduct;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public async Task<Tnav?> GetDataNavByProduct(long idProduct)
        {
            try
            {
                Tnav? tNav = await context.Tnavs.OrderByDescending(x => x.Navdate).Where(y => y.Idproduct == idProduct && y.Navdate <= DateTime.Now).FirstOrDefaultAsync();
                return tNav;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task<Tnav?> GetDataNavByProductAndDate(long idProduct, DateTime date)
        {
            try
            {
                Tnav? tNav = await context.Tnavs.OrderByDescending(x => x.Navdate).Where(y => y.Idproduct == idProduct && y.Navdate == date).FirstOrDefaultAsync();
                return tNav;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async ValueTask<bool> GetDataHoliday(int idCurrency, int dayInWeek)
        {
            try
            {
                bool IsHoliday = false;

                var getDataHolidayGeneral = await context.TholidayGenerals.Where(x => x.DayInWeek == dayInWeek && x.Idcurrency == idCurrency).FirstOrDefaultAsync();
                if (getDataHolidayGeneral != null)
                {
                    IsHoliday = true;
                }
                else
                {
                    var getDataHoliday = await context.Tholidays.Where(x => x.HolidayDate == DateTime.Now.Date && (x.Idcurrency == idCurrency)).FirstOrDefaultAsync();
                    if (getDataHoliday != null)
                        IsHoliday = true;
                }

                return IsHoliday;
            }
            catch (Exception)
            {
                throw;
            }
            
        }
        public async Task<TcustBankAccount?> GetDataBankAccount(long IDCustomer)
        {
            try
            {
                TcustBankAccount? tcustBankAccount = await context.TcustBankAccounts.Where(x => x.Idcustomer.Equals(IDCustomer)).OrderByDescending(x => x.IsPriority).FirstOrDefaultAsync();
                return tcustBankAccount;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public async Task<TcustBankAccount?> GetDataBankAccountByAccountNo(string AccountNo)
        {
            try
            {
                TcustBankAccount? tcustBankAccount = await context.TcustBankAccounts.Where(x => x.AccountNo == AccountNo).OrderByDescending(x => x.IsPriority).FirstOrDefaultAsync();
                return tcustBankAccount;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public async ValueTask<double> GetQuotaCPF(long IDProduct)
        {
            double Quota;

            var res = await context.fnInqQuotaCPF.FromSqlInterpolated($"select [dbo].[fnInqQuotaCPF] ({"QuotaCPF"}, {IDProduct}) as ResultQuota").SingleOrDefaultAsync();
            Quota = res.ResultQuota;
            return Quota;
        }
        public async ValueTask<DateTime> CheckHoliday(string checkDate, int rangeDate)
        {
            DateTime NoHoliday;

            //NoHoliday = context.fnHolidayAdd.FromSqlInterpolated($"select [dbo].[fn_HolidayAdd] ({checkDate}, {rangeDate}) as resultDate").FirstOrDefaultAsync().Result.resultDate;
            var res = await context.fnHolidayAdd.FromSqlInterpolated($"select [dbo].[fn_HolidayAdd] ({checkDate}, {rangeDate}) as resultDate").SingleOrDefaultAsync();
            NoHoliday = res.resultDate;
            return NoHoliday;
        }
        public async Task<TproductOfferingPeriod?> GetTproductOfferingPeriod(long IDProduct)
        {
            TproductOfferingPeriod? dataOfferingProduct = await context.TproductOfferingPeriods.OrderByDescending(x => x.IdproductOfferingPeriod)
                                                                                               .Where(x => x.Idproduct == IDProduct
                                                                                               && x.BeginDate <= DateTime.Now && x.EndDate >= DateTime.Now)
                                                                                               .FirstOrDefaultAsync();
            return dataOfferingProduct;
        }
        public async Task<TproductExitWindow?> GetTproductExitWindow(long IDProduct)
        {
            TproductExitWindow? dataExitWindow = await context.TproductExitWindows.OrderByDescending(x => x.IdproductExitWindow)
                                                                                  .Where(x => x.Idproduct == IDProduct && x.BeginDate <= DateTime.Now && x.EndDate >= DateTime.Now)
                                                                                  .FirstOrDefaultAsync();
            return dataExitWindow;
        }
        public async Task<TcustBankAccount?> GetDataBankAccountCPF(long IDCustomer, int idCurrency, string CustAccountNo)
        {
            TcustBankAccount? getDataBankAccount = await context.TcustBankAccounts.Where(x => x.Idcustomer == IDCustomer && x.Idcurrency == idCurrency && x.AccountNo.Equals(CustAccountNo)).FirstOrDefaultAsync();
            return getDataBankAccount;
        }
        public async Task<TproductBankAccount?> GetDataProductBankAccount(long IDProduct, int IDCurrency, string IDCategory)
        {
            TproductBankAccount? getDataProductBankAccount = await context.TproductBankAccounts
                                                            .Where(x => x.Idproduct == IDProduct && x.Idcurrency == IDCurrency && x.IsMandatory == true && x.Idcategory.Contains(IDCategory)).FirstOrDefaultAsync();
            return getDataProductBankAccount;
        }
        public async Task<Tagent?> GetDataAgent(string channelID)
        {
            Tagent? dataAgent = await context.Tagents.Where(x => x.NameAgent.Equals("Channel " + channelID) && x.AgentLevelId == 4).FirstOrDefaultAsync();
            return dataAgent;
        }
        public async Task<TsubAccount?> GetDataSubAccount(long IDProduct, long IDCustomer)
        {
            TsubAccount? dataSubAccount = await context.TsubAccounts.Where(x => x.Idproduct == IDProduct && x.Idcustomer == IDCustomer).FirstOrDefaultAsync();
            return dataSubAccount;
        }
        public async ValueTask<double> GetBalancePerSubAccount(long IDSubAccount, DateTime date)
        {
            double BalanceUnit = 0;

            fn_TOutstandingHistoryFIFO_GetBalancePerSubAccount_Result? GetBalancePerSubAccount_Result = await context.fn_TOutstandingHistoryFIFO_GetBalancePerSubAccount_Result.FromSqlRaw("select * from dbo.fn_TOutstandingHistoryFIFO_GetBalancePerSubAccount({0},{1}) ", IDSubAccount, date).FirstOrDefaultAsync();
            if (GetBalancePerSubAccount_Result != null)
                BalanceUnit = Convert.ToDouble(GetBalancePerSubAccount_Result.BalanceUnit);

            return BalanceUnit;
        }
        public async ValueTask<int> CheckQuestionRiskProfile(int QuestionNo)
        {
            int QuestionID = 0;
            QuestionID = await context.TrefProfileQuestions.Where(x => x.QuestionId == QuestionNo).Select(x => x.QuestionId).FirstOrDefaultAsync();
            return QuestionID;
        }
        public async ValueTask<int> CheckAnswerRiskProfile(int questionID, string answer)
        {
            int QuestionOptionID = 0;
            QuestionOptionID = await context.TrefProfileQuestionOptions.Where(x => x.QuestionId == questionID && x.OptionId.Equals(answer)).Select(x => x.QuestionOptionId).FirstOrDefaultAsync();
            return QuestionOptionID;
        }
        public async ValueTask<string?> GetKodeKota(string tempCode)
        {
            string? result = string.Empty;
            result = await context.TrefKotaNews.Where(x => x.KodeKota.Equals(tempCode)).AsNoTracking().Select(x => x.KodeKota).FirstOrDefaultAsync();
            return result;
        }
        public async ValueTask<string?> GetDataByDisplay(string mainDisplay, string groupName)
        {
            string? result = await context.VTreferenceDetails.Where(x => x.Display.Contains(mainDisplay) && x.GroupName.Equals(groupName))
                            .Select(x => x.Display).FirstOrDefaultAsync();
            return result;
        }
        public async Task<List<RefferenceDetailValue>> TRefferenceDetailValueByManyGroupName(string[] groupName)
        {
            List<RefferenceDetailValue> refferenceDetailValue = new();
            refferenceDetailValue = await (from detail in context.TreferenceDetails
                                           join grup in context.TreferenceGroups on detail.TreferenceGroupId equals grup.TreferenceGroupId
                                           where groupName.Contains(grup.GroupName)
                                           select new RefferenceDetailValue()
                                           {
                                               AltValue5 = detail.AltValue5 ?? "",
                                               Display = detail.Display,
                                               GroupName = grup.GroupName,
                                               MainValue = detail.MainValue
                                           }).ToListAsync();

            return refferenceDetailValue;
        }
        public async ValueTask<long> GetDataCustomerByIDNumber(string idNumber, string channelID)
        {
            long IDCustomer;
            IDCustomer = await context.Tcustomers.Where(x => x.Idnumber.Equals(idNumber) && x.SysCreatedBy.Equals(channelID))
                                                        .Select(x => x.Idcustomer).FirstOrDefaultAsync();

            return IDCustomer;
        }
        public async Task<Tcustomer?> GetDataCustomerByIDNumberV2(string idNumber, string channelID)
        {
            Tcustomer? dataCustomer = await context.Tcustomers.Where(x => x.Idnumber.Equals(idNumber) && x.SysCreatedBy.Equals(channelID)).FirstOrDefaultAsync();
            return dataCustomer;
        }
        public async ValueTask<string?> GetDataRiskProfileName(int? riskProfileID)
        {
            string? resultProfileName = string.Empty;
            resultProfileName = await context.TrefProfiles.Where(x => x.ProfileId == riskProfileID).Select(x => x.ProfileName).FirstOrDefaultAsync();
            return resultProfileName;
        }
        public async Task<TcustomerRiskProfile?> GetDataRiskProfile(long idCustomer)
        {
            TcustomerRiskProfile? dataRiskProfile = await context.TcustomerRiskProfiles.Where(x => x.Idcustomer == idCustomer).FirstOrDefaultAsync();
            return dataRiskProfile;
        }
        public async Task<List<TcustomerRiskProfileAnswer>> GetDataRiskProfileAnswer(long custRiskProfileID)
        {
            List<TcustomerRiskProfileAnswer> dataRiskProfileAnswer = await context.TcustomerRiskProfileAnswers.Where(x => x.TcustomerRiskProfileId == custRiskProfileID).ToListAsync();
            return dataRiskProfileAnswer;
        }
        public async Task<TproductRegInvestmentPlan> GetProductInvestmentPlan(long iDProduct, int programCode, bool isActive, int channelID, DateTime _dt)
        {
            return await context.TproductRegInvestmentPlans.Where(x => x.Idproduct == iDProduct && x.TregularInvestmentPlanId == programCode && x.IsActive == isActive && x.ChannelId == channelID && x.EffectiveDate <= _dt).OrderByDescending(x => x.EffectiveDate).OrderByDescending(x => x.SysCreatedTime).FirstOrDefaultAsync();
        }
        public async Task<TsubAccount> GetSubAccountByIDSubAccount(long? iDSubAccount)
        {
            return await context.TsubAccounts.Where(x => x.IdsubAccount.Equals(iDSubAccount)).FirstOrDefaultAsync();
        }
        public async Task<TregularInvestmentPlanFeeDetail> GetFeeByTenorAndAmount(long feeId, int tenor, double amount)
        {
            return await context.TregularInvestmentPlanFeeDetails.Where(x => x.TregularInvestmentPlanFeeId.Equals(feeId) && x.Tenor.Equals(tenor) && x.MinimumAmount <= amount && (x.MaximumAmount == null ? true : x.MaximumAmount >= amount ? true : false)).FirstOrDefaultAsync();
        }
        public async Task<Tagent> GetAgentByCode(string agentCode)
        {
            return await context.Tagents.Where(x => x.CodeAgent.ToUpper().Contains(agentCode)).FirstOrDefaultAsync();
        }
        public async Task<List<TcustomerRegInvestmentPlan>> TCustomerRegInvestmentPlan_SelectByCustomerProduct(long idcustomer, long idproduct)
        {
            return await context.TcustomerRegInvestmentPlans.Where(x => x.Idcustomer == idcustomer && x.Idproduct == idproduct).ToListAsync();
        }
        public async Task<string> GenerateNewSubAccount(long idCustomer, long idProduct, int type)
        {
            string newSubAccountNo = string.Empty;
            string typeProgram = string.Empty;

            if (type == 1)
            {
                typeProgram = "CRISPR";
            }
            else if (type == 2)
            {
                typeProgram = "CRISP+";
            }
            else
            {
                typeProgram = "REGULER";
            }

            Tcustomer cust = await context.Tcustomers.Where(x => x.Idcustomer.Equals(idCustomer)).FirstOrDefaultAsync();

            return newSubAccountNo = cust.UnitHolderIdno + " " + idProduct.ToString() + " " + typeProgram;            
        }
        public async ValueTask<short> GetTransactionGenerator(string channelID)
        {
            short result = 0;
            result = await context.TrefTransactionGenerators.Where(x => x.GeneratorCode.Equals(channelID)).Select(x => x.GeneratorId).FirstOrDefaultAsync();
            return result;
        }
        public async Task<TproductBankAccount?> GetTproductBankAccountByCategory(long iDProduct, string[] iDCategory)
        {
            try
            {
                TproductBankAccount? tproductBankAccount = await context.TproductBankAccounts.
                                                          Where(x => x.Idproduct.Equals(iDProduct)
                                                          && iDCategory.Contains(x.Idcategory)).OrderByDescending(x => x.IsMandatory).
                                                          FirstOrDefaultAsync();
                return tproductBankAccount;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public async ValueTask<double?> GetTransactionFee(short channelID, string productCode, string transactionCategory, DateTime transactiondate)
        {
            double? vFeeFeePercentage = 0;

            if (transactionCategory.Equals("SWT"))
            {
                vFeeFeePercentage = await (from pf in context.TproductTransactionFees
                                           join p in context.Tproducts on pf.Idproduct equals p.Idproduct
                                           join ttf in context.TtransactionFeeDetails on pf.TtransactionFeeId equals ttf.TtransactionFeeId
                                           where pf.ChannelId == channelID && pf.TrxIdcategory == "SWTOT" && p.ProductCode == productCode
                                           select ttf.FeePercentage).FirstOrDefaultAsync();
            }
            else
            {
                vFeeFeePercentage = await (from pf in context.TproductTransactionFees
                                           join p in context.Tproducts on pf.Idproduct equals p.Idproduct
                                           join ttf in context.TtransactionFeeDetails on pf.TtransactionFeeId equals ttf.TtransactionFeeId
                                           where pf.ChannelId == channelID && pf.TrxIdcategory == transactionCategory && p.ProductCode == productCode && pf.TrxFeeType == 1
                                           && pf.BeginDate <= transactiondate
                                           && (pf.EndDate >= transactiondate || pf.EndDate == null)
                                           orderby pf.BeginDate descending
                                           select ttf.FeePercentage).FirstOrDefaultAsync();

            }

            return vFeeFeePercentage;
        }
        public async Task<TcustBankAccount?> GetTcustBankAccount(int iDCurrency, long iDCustomer)
        {
            try
            {
                TcustBankAccount? tcustBankAccount = await context.TcustBankAccounts.Where(x => x.Idcurrency == iDCurrency && x.Idcustomer == iDCustomer).FirstOrDefaultAsync();

                return tcustBankAccount;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public async Task<TcustBankAccount?> GetTcustBankAccountRED(string AccountNo, long iDCustomer)
        {
            try
            {
                TcustBankAccount? tcustBankAccount = await context.TcustBankAccounts.Where(x => x.AccountNo.Equals(AccountNo) && x.Idcustomer == iDCustomer).FirstOrDefaultAsync();

                return tcustBankAccount;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public async Task<TcustomerRiskProfile?> GetTcustomerRiskProfile(long iDCutomer, DateTime date)
        {
            try
            {
                TcustomerRiskProfile? tcustomerRiskProfile = await context.TcustomerRiskProfiles.Where(x => x.Idcustomer.Equals(iDCutomer) && x.EffectiveDate <= date).
                                                                    OrderByDescending(x => x.EffectiveDate).
                                                                    ThenByDescending(x => x.SysCreatedTime).
                                                                    FirstOrDefaultAsync();
                return tcustomerRiskProfile;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public async Task<TcustomerProductRiskProfileMapping?> GetTcustomerProductRiskProfileMapping(int? custProfileID, int? prodProfileID)
        {
            try
            {
                TcustomerProductRiskProfileMapping? tcustomerProductRiskProfileMapping = await context.TcustomerProductRiskProfileMappings.Where(x => x.CustomerProfileId == custProfileID
                                                                                        && x.ProductProfileId == prodProfileID).FirstOrDefaultAsync();

                return tcustomerProductRiskProfileMapping;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public async Task<List<Ttransaction>> GetTransactionsRedBeforeAppBySubAcc(long iDSubAccount, long iDProduct, DateTime beginDate, DateTime endDate)
        {
            try
            {
                string[] category = { "SWTOT", "RED", "TROUT", "ADJDN" };
                string[] status = { "ENTRIED", "VERIFIED", "CORRECTED", "GOODFUND", "TOBECORRECTED", "UNGOODFUND", "TBCRCTD" };

                List<Ttransaction> trxList = await context.Ttransactions.Where(x => x.IdsubAccount == iDSubAccount && x.Idproduct == iDProduct && status.Contains(x.Idstatus)
                                               && category.Contains(x.Idcategory)
                                               && DateTime.Compare((DateTime)x.Navdate, beginDate) <= 0
                                               && DateTime.Compare((DateTime)x.Navdate, endDate) >= 0).ToListAsync<Ttransaction>();

                return trxList;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public async Task<TfundHouse?> GetFhId(int? fhId)
        {
            TfundHouse? getDataFundHouse = await context.TfundHouses.Where(x => x.FhId == fhId).FirstOrDefaultAsync();
            return getDataFundHouse;
        }
        public async Task<TrefCurrency?> GetDataCurrency(int idCurrency)
        {
            TrefCurrency? result = await context.TrefCurrencies.Where(x => x.Idcurrency == idCurrency).FirstOrDefaultAsync();
            return result;
        }
        public async Task<TproductBankAccount?> GetDataProductBankAccountByIDProduct(long IDProduct)
        {
            TproductBankAccount? getDataProductBankAccount = await context.TproductBankAccounts
                                                            .Where(x => x.Idproduct == IDProduct).OrderByDescending(x => x.IsMandatory).FirstOrDefaultAsync();
            return getDataProductBankAccount;
        }
        public async Task<Ttransaction?> GetDataTTransactionByIDSubAccount(long iDSubAccount)
        {
            Ttransaction? result = await context.Ttransactions.Where(x => x.IdsubAccount == iDSubAccount).FirstOrDefaultAsync();
            return result;
        }
        public async Task<List<Ttransaction>> GetDataListTTransactionByIDSubAccount(long idSubAccount, string[] status, DateTime _BeginDate, DateTime _EndDate)
        {
            List<Ttransaction> result = await context.Ttransactions.Where(x => x.IdsubAccount.Equals(idSubAccount) && status.Contains(x.Idstatus) && EF.Functions.DateDiffDay(x.Navdate, _BeginDate) <= 0 && EF.Functions.DateDiffDay(x.Navdate, _EndDate) >= 0).OrderByDescending(x => x.TransactionDate).Take(10).ToListAsync();
            return result;
        }
        public async Task<TcustomerRegInvestmentPlan?> GetDataTcustomerRegInvestmentPlan(long _genId)
        {
            TcustomerRegInvestmentPlan? result = await context.TcustomerRegInvestmentPlans.Where(x => x.TcustomerRegInvestmentPlanId == _genId).FirstOrDefaultAsync();
            return result;
        }
        public async Task<TregularInvestmentPlan?> GetDataTregularInvestmentPlan(long TcustomerRegInvestmentPlanId)
        {
            TregularInvestmentPlan? result = await context.TregularInvestmentPlans.Where(x => x.TregularInvestmentPlanId == TcustomerRegInvestmentPlanId).FirstOrDefaultAsync();
            return result;
        }
        public async Task<List<Ttransaction>> TtransactionPendByIDSubAccount(long idSubAccount, DateTime _BeginDate, DateTime _EndDate)
        {
            string[] category = { "SWTOT", "RED", "TROUT", "ADJDN" };
            string[] status = { "ENTRIED", "VERIFIED", "CORRECTED", "GOODFUND", "TBCRCTD", "UNGOODFUND" };

            var trx = await context.Ttransactions.Where(x => x.IdsubAccount.Equals(idSubAccount) 
                                                        && status.Contains(x.Idstatus) && category.Contains(x.Idcategory) 
                                                        && EF.Functions.DateDiffDay(x.Navdate, _BeginDate) <= 0 
                                                        && EF.Functions.DateDiffDay(x.Navdate, _EndDate) >= 0)
                                                .OrderByDescending(x => x.TransactionDate).Take(10).ToListAsync();

            return trx;
        }
        public async Task<List<Ttransaction>> GetDataTransactionByIDCustomer(long idCustomer, string[]? statusTrans)
        {
            List<Ttransaction> result = await context.Ttransactions.Where(x => x.Idcustomer == idCustomer & statusTrans.Contains(x.Idstatus)).Include(x => x.IdproductNavigation).ToListAsync();
            return result;
        }
        public async Task<List<Ttransaction>> GetDataTransactionByIDCustomerAndDate(long idCustomer, DateTime? beginDate, DateTime? endDate, string[]? statusTrans)
        {
            List<Ttransaction> result = await context.Ttransactions.Where(x => x.Idcustomer == idCustomer && x.TransactionDate.Value.Date >= beginDate.Value.Date && x.TransactionDate.Value.Date <= endDate.Value.Date && statusTrans.Contains(x.Idstatus))
                                                     .Include(x => x.IdproductNavigation).ToListAsync();
            return result;
        }
        public async Task<TtransactionBankAccount?> GetDataBankAccountByIDTransaction(long IDTransaction)
        {
            TtransactionBankAccount? transBankAccount = await context.TtransactionBankAccounts.Where(x => x.Idtransaction == IDTransaction && (x.TransAccountType.Equals(3) || x.TransAccountType.Equals(4))).FirstOrDefaultAsync();
            return transBankAccount;
        }
        public async Task<List<VTreferenceDetail>> GetDataProductCategory()
        {
            List<VTreferenceDetail> listResult = await context.VTreferenceDetails.Where(x => x.GroupName.Equals("ProductCategory")).ToListAsync();
            return listResult;
        }
    }
}