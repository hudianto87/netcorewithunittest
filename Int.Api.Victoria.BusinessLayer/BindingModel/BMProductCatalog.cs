using System.ComponentModel.DataAnnotations;

namespace Int.Api.Victoria.BusinessLayer.BindingModel
{
    public class BMProductCatalog
    {
        [Required][MaxLength(10)] public string ChannelID { get; set; } = string.Empty;
        [Required][MaxLength(25)] public string ProductCategory { get; set; } = string.Empty;
        [Required][MaxLength(10)] public string ProductCode { get; set; } = string.Empty;
    }
}
