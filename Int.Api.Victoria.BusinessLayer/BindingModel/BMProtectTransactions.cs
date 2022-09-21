using System.ComponentModel.DataAnnotations;

namespace Int.Api.Victoria.BusinessLayer.BindingModel
{
    public class BMProtectTransactions
    {
        [Required][MaxLength(10)] public string ChannelID { get; set; } = string.Empty;
        [Required][MaxLength(10)] public string TransType { get; set; } = string.Empty;
        [Required][MaxLength(16)] public string CIF { get; set; } = string.Empty;
        [Required][MaxLength(10)] public string ProductCode { get; set; } = string.Empty;
        [Required][MaxLength(30)] public string CustomerAccountNo { get; set; } = string.Empty;
        [Required] public double Amount { get; set; } = 0;
        [Required] public double FeePercentage { get; set; } = 0;
        [Required] public double FeeAmount { get; set; } = 0;
        [Required] public double Charges { get; set; } = 0;
        [Required] public double NetAmount { get; set; } = 0;
        [Required] public double Units { get; set; } = 0;
        [Required] public long HoldID { get; set; }
        [Required] public string RefNo { get; set; } = string.Empty;
    }
}
