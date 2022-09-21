using System.ComponentModel.DataAnnotations;

namespace Int.Api.Victoria.BusinessLayer.BindingModelResult
{
    public class BMRHistoryTransaction
    {
        public long IDTransaction { get; set; }
        [MaxLength(5)] public string IDCategory { get; set; } = string.Empty;
        [MaxLength(10)] public string IDStatus { get; set; } = string.Empty;
        public DateTime? TransactionDate { get; set; }
        [MaxLength(100)] public string? ReferenceNo { get; set; } = string.Empty;
        [MaxLength(10)] public string ProductCode { get; set; } = string.Empty;
        [MaxLength(100)] public string ProductName { get; set; } = string.Empty;
        [MaxLength(50)] public string ProductCategory { get; set; } = string.Empty;
        [MaxLength(30)] public string AccountNo { get; set; } = string.Empty;
        [MaxLength(100)] public string AccountName { get; set; } = string.Empty;
        public double? FeeAmount { get; set; }
        public double? FeeTaxAmount { get; set; }
        public double? NetAmount { get; set; }
        public double? Unit { get; set; }
        public double? NAVValue { get; set; }
        public double? TotalAmount { get; set; }
        [MaxLength(50)] public string SUBType { get; set; } = string.Empty;
    }
}
