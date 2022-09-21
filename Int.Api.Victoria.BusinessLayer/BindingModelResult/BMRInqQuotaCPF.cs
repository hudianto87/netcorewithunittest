using System.ComponentModel.DataAnnotations;

namespace Int.Api.Victoria.BusinessLayer.BindingModelResult
{
    public class BMRInqQuotaCPF
    {
        [Required] [MaxLength(10)] public string ProductCode { get; set; } = string.Empty;
        [Required] public double AvailableQuota { get; set; }
    }
}
