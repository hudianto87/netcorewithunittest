using System.ComponentModel.DataAnnotations;

namespace Int.Api.Victoria.BusinessLayer.BindingModelResult
{
    public class BMRRiskProfile
    {
        [Required] public long CustomerID { get; set; }
        [Required][MaxLength(16)]public string CIF { get; set; } = string.Empty;
        [Required] public int? RiskProfileID { get; set; }
        [Required][MaxLength(16)] public string RiskProfileName { get; set; } = string.Empty;
    }
}
