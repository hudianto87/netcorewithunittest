using Int.Api.Victoria.BusinessLayer.BindingModelResult;
using Int.Api.Victoria.DataAccess.Models;

namespace Int.Api.Victoria.BusinessLayer.BusinessObject.InterfaceMaster
{
    interface IReference
    {
        Task<VTreferenceDetail?> GetChannel(string channelName);
        Task<List<VTreferenceDetail>> GetReferenceByGroupname(string GroupName);
        Task<Tcustomer?> GetCustomerByCif(string CIF);
        Task<Tconfig?> GetConfigByKey(string key);
        Task<Tproduct?> GetProductByProductcode(string productCode);
        Task<Tproduct?> GetProductByIdProduct(long idProduct);
        Task<Tnav?> GetDataNavByProduct(long idProduct);
        Task<Tnav?> GetDataNavByProductAndDate(long idProduct, DateTime date);
        ValueTask<bool> GetDataHoliday(int idCurrency, int dayInWeek);
        Task<TcustBankAccount?> GetDataBankAccount(long IDCustomer);
        Task<TcustBankAccount?> GetDataBankAccountByAccountNo(string AccountNo);
        ValueTask<double> GetQuotaCPF(long IDProduct);
        ValueTask<DateTime> CheckHoliday(string checkDate, int rangeDate);
        Task<TproductOfferingPeriod?> GetTproductOfferingPeriod(long IDProduct);
        Task<TproductExitWindow?> GetTproductExitWindow(long IDProduct);
        Task<TcustBankAccount?> GetDataBankAccountCPF(long IDCustomer, int idCurrency, string CustAccountNo);
        Task<TproductBankAccount?> GetDataProductBankAccount(long IDProduct, int IDCurrency, string IDCategory);
        Task<Tagent?> GetDataAgent(string channelID);
        Task<Tcustomer?> GetDataCustomer(string CIF, string idNumber, string channelID);
        Task<TsubAccount?> GetDataSubAccount(long IDProduct, long IDCustomer);
        ValueTask<double> GetBalancePerSubAccount(long IDSubAccount, DateTime date);
        ValueTask<int> CheckQuestionRiskProfile(int QuestionNo);
        ValueTask<int> CheckAnswerRiskProfile(int questionID, string answer);
        ValueTask<string?> GetKodeKota(string tempCode);
        ValueTask<string?> GetDataByDisplay(string mainDisplay, string groupName);
        Task<List<RefferenceDetailValue>> TRefferenceDetailValueByManyGroupName(string[] groupName);
        ValueTask<long> GetDataCustomerByIDNumber(string idNumber, string channelID);
        Task<Tcustomer?> GetDataCustomerByIDNumberV2(string idNumber, string channelID);
        ValueTask<string?> GetDataRiskProfileName(int? riskProfileID);
        Task<TcustomerRiskProfile?> GetDataRiskProfile(long idCustomer);
        Task<List<TcustomerRiskProfileAnswer>> GetDataRiskProfileAnswer(long custRiskProfileID);
        Task<TproductRegInvestmentPlan> GetProductInvestmentPlan(long iDProduct, int programCode, bool isActive, int channelID, DateTime _dt);
        Task<TsubAccount> GetSubAccountByIDSubAccount(long? iDSubAccount);
        Task<TregularInvestmentPlanFeeDetail> GetFeeByTenorAndAmount(long feeId, int tenor, double amount);
        Task<Tagent> GetAgentByCode(string agentCode);
        Task<List<TcustomerRegInvestmentPlan>> TCustomerRegInvestmentPlan_SelectByCustomerProduct(long idcustomer, long idproduct);
        Task<string> GenerateNewSubAccount(long idCustomer, long idProduct, int type);
        ValueTask<short> GetTransactionGenerator(string channelID);
        Task<TproductBankAccount?> GetTproductBankAccountByCategory(long iDProduct, string[] iDCategory);
        ValueTask<double?> GetTransactionFee(short channelID, string productCode, string transactionCategory, DateTime transactiondate);
        Task<TcustBankAccount?> GetTcustBankAccount(int iDCurrency, long iDCustomer);
        Task<TcustBankAccount?> GetTcustBankAccountRED(string AccountNo, long iDCustomer);
        Task<TcustomerRiskProfile?> GetTcustomerRiskProfile(long iDCutomer, DateTime date);
        Task<TcustomerProductRiskProfileMapping?> GetTcustomerProductRiskProfileMapping(int? custProfileID, int? prodProfileID);
        Task<List<Ttransaction>> GetTransactionsRedBeforeAppBySubAcc(long iDSubAccount, long iDProduct, DateTime beginDate, DateTime endDate);
        Task<TfundHouse?> GetFhId(int? fhId);
        Task<TrefCurrency?> GetDataCurrency(int idCurrency);
        Task<TproductBankAccount?> GetDataProductBankAccountByIDProduct(long IDProduct);
        Task<Ttransaction?> GetDataTTransactionByIDSubAccount(long iDSubAccount);
        Task<List<Ttransaction>> GetDataListTTransactionByIDSubAccount(long idSubAccount, string[] status, DateTime _BeginDate, DateTime _EndDate);
        Task<TcustomerRegInvestmentPlan?> GetDataTcustomerRegInvestmentPlan(long _genId);
        Task<TregularInvestmentPlan?> GetDataTregularInvestmentPlan(long TcustomerRegInvestmentPlanId);
        Task<List<Ttransaction>> TtransactionPendByIDSubAccount(long idSubAccount, DateTime _BeginDate, DateTime _EndDate);
        Task<List<Ttransaction>> GetDataTransactionByIDCustomer(long idCustomer, string[] statusTrans);
        Task<List<Ttransaction>> GetDataTransactionByIDCustomerAndDate(long idCustomer, DateTime? beginDate, DateTime? endDate, string[] statusTrans);
        Task<TtransactionBankAccount?> GetDataBankAccountByIDTransaction(long IDTransaction);
        Task<List<VTreferenceDetail>> GetDataProductCategory();
    }
}
