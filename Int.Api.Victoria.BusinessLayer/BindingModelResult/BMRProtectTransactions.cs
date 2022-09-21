using System.ComponentModel.DataAnnotations;

namespace Int.Api.Victoria.BusinessLayer.BindingModelResult
{
    public class BMRProtectTransactions
    {
        [Required][MaxLength(16)] public string CIF { get; set; } = string.Empty;
        [Required][MaxLength(10)] public string ProductCode { get; set; } = string.Empty;
        [Required][MaxLength(50)] public string CustomerAccountNo { get; set; } = string.Empty;
        [Required][MaxLength(100)] public string CustomerAccountName { get; set; } = string.Empty;
        public double Amount { get; set; } = 0;
        public double Units { get; set; } = 0;
        public long TransactionID { get; set; }
        [Required][MaxLength(50)] public string RefNo { get; set; } = string.Empty;
    }
}