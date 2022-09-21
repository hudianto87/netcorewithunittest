using System.ComponentModel.DataAnnotations;

namespace Int.Api.Victoria.BusinessLayer.BindingModelResult
{
    public class BMRTransaction
    {
        [Required][MaxLength(16)] public string CIF { get; set; } = string.Empty;
        [Required][MaxLength(10)] public string ProductCode { get; set; } = string.Empty;
        [MaxLength(10)] public string TransactionCategory { get; set; } = string.Empty;
        [Required][MaxLength(10)] public string TransactionDate { get; set; } = string.Empty;
        [Required][MaxLength(10)] public string SettlementDate { get; set; } = string.Empty;
        [Required][MaxLength(10)] public string NAVDate { get; set; } = string.Empty;
        public List<TransactionList> TransactionLists { get; set; } = new List<TransactionList>();
        [Required][MaxLength(50)] public string CustBankAccountNo { get; set; } = string.Empty;
        [MaxLength(10)] public string ProductCodeTo { get; set; } = string.Empty;
        [Required][MaxLength(50)] public string ProdBankAccountNo { get; set; } = string.Empty;
        public DateTime PaymentTimeLimit { get; set; }
    }
    public class TransactionList
    {
        [Required] public double Amount { get; set; }
        [Required] public double NetAmount { get; set; }
        public double FeeAmount { get; set; }
        public double TaxAmount { get; set; }
        public double Charges { get; set; }
        [Required][MaxLength(1024)] public string Remark { get; set; } = string.Empty;
        public long HoldID { get; set; }
        [Required][MaxLength(50)] public string RefNo { get; set; } = string.Empty;
        public bool IsRedeemAll { get; set; }
        public long TransactionID { get; set; }
    }
}
