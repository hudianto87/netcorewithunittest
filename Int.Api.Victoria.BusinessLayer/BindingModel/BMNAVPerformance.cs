using System.ComponentModel.DataAnnotations;
namespace Int.Api.Victoria.BusinessLayer.BindingModel
{
    public class BMNAVPerformance
    {
        [Required][MaxLength(20)] public string ChannelID { get; set; } = string.Empty;
        [Required][MaxLength(10)] public string ProductCode { get; set; } = string.Empty;
        [Required][MaxLength(10)] public string RangeType { get; set; } = string.Empty;
        [Required] public int RangeValue { get; set; }
    }
}