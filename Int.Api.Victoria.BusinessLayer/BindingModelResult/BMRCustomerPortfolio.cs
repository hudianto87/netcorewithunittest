using System.ComponentModel.DataAnnotations;

namespace Int.Api.Victoria.BusinessLayer.BindingModelResult
{
    public class BMRCustomerPortfolio
    {
        [Required][MaxLength(16)]public string CIF { get; set; } = string.Empty;
        [MaxLength(50)] public string CustRiskProfileType { get; set; } = string.Empty;
        [MaxLength(20)] public string CustRiskProfilingDate { get; set; } = string.Empty;
        [MaxLength(20)] public string CustRiskProfileExpiredDate { get; set; } = string.Empty;
        [Required][MaxLength(20)] public string CurrencyDate { get; set; } = string.Empty;
        public double TotalAmountInIDR { get; set; }
        public List<RInqCustPortfolio_Product> ProductList { get; set; } = new List<RInqCustPortfolio_Product>();
        [Required] public bool OutstandingFlag { get; set; }
    }
    public class RInqCustPortfolio_Product
    {
        [MaxLength(10)] public string ProductCode { get; set; } = string.Empty;
        [MaxLength(100)] public string ProductName { get; set; } = string.Empty;
        [Required][MaxLength(20)] public string ProductCategory { get; set; } = string.Empty;
        [Required][MaxLength(20)] public string FundHouseCode { get; set; } = string.Empty;
        [Required][MaxLength(50)] public string FundHouseName { get; set; } = string.Empty;
        [MaxLength(3)] public string Currency { get; set; } = string.Empty;
        [Required] public double CurrencyRate { get; set; }
        [Required][MaxLength(10)] public string MFType { get; set; } = string.Empty;
        [Required][MaxLength(100)] public string ProdBankAccount { get; set; } = string.Empty;
        public double TotalUnits { get; set; }
        public double NAVPerUnit { get; set; }
        [MaxLength(20)] public string NAVDate { get; set; } = string.Empty;
        public double TotalAmount { get; set; }
        public double TotalAmountInIDR { get; set; }
        public double UGL { get; set; }
        public double UGLPercentage { get; set; }
        public bool UGLFlag { get; set; }
        public List<InvestmentAccount> InvestmentAccountList { get; set; } = new List<InvestmentAccount>();
    }
    public class InvestmentAccount
    {
        [MaxLength(100)] public string InvestmentAccountNo { get; set; } = string.Empty;
        [MaxLength(100)] public string InvestmentType { get; set; } = string.Empty;
        public double Units { get; set; }
        public double Amount { get; set; }
        public List<RInqCustPortfolio_Product_Transaction> TransactionList { get; set; } = new List<RInqCustPortfolio_Product_Transaction>();
    }
    public class RInqCustPortfolio_Product_Transaction
    {
        [MaxLength(20)] public string TransactionDate { get; set; } = string.Empty;
        [MaxLength(5)] public string TransactionType { get; set; } = string.Empty;
        [MaxLength(100)] public string ProductFrom { get; set; } = null!;
        [MaxLength(100)] public string ProductTo { get; set; } = string.Empty;
        public double Unit { get; set; }
        public double UnitTo { get; set; }
        public double NAVPerUnitTrx { get; set; }
        public double NAVPerUnitTo { get; set; }
        public string NAVDateTrx { get; set; } = string.Empty;
        public double AmountTrx { get; set; }
        public double FeeAmount { get; set; }
        public double TaxAmount { get; set; }
        public double Charges { get; set; }
        public double NetAmount { get; set; }
    }
}
