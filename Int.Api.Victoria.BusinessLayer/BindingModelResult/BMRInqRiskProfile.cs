using System.ComponentModel.DataAnnotations;

namespace Int.Api.Victoria.BusinessLayer.BindingModelResult
{
    public class BMRInqRiskProfile
    {
        [Required] [MaxLength(16)] public string CIF { get; set; } = string.Empty;
        [Required] [MaxLength(5)] public string RiskProfileID { get; set; } = string.Empty;
        [Required] [MaxLength(250)] public string RiskProfileName { get; set; } = string.Empty;
        [Required] [MaxLength(10)] public string RiskProfileExpDt { get; set; } = string.Empty;
        [MaxLength(50)] public string SIDMF { get; set; } = string.Empty;
        [Required] public bool SIDMFProcessStatus { get; set; }
        [Required][MaxLength(50)] public string IFUA { get; set; } = string.Empty;
    }
}
