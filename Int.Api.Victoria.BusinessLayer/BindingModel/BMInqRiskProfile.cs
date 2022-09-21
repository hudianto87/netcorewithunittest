using System.ComponentModel.DataAnnotations;

namespace Int.Api.Victoria.BusinessLayer.BindingModel
{
    public class BMInqRiskProfile
    {
        [Required] public string ChannelID { get; set; } = String.Empty;
        [Required] public string CIF { get; set; } = String.Empty;
    }
}
