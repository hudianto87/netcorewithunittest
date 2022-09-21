using System.ComponentModel.DataAnnotations;

namespace Int.Api.Victoria.BusinessLayer.BindingModel
{
    public class BMProductCategory
    {
        [Required][MaxLength(10)] public string ChannelID { get; set; } = string.Empty;
    }
}
