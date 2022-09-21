using System.ComponentModel.DataAnnotations;

namespace Int.Api.Victoria.BusinessLayer.BindingModel
{
    public class BMInqQuotaCPF
    {
        [Required] [MaxLength(10)] public string ChannelID { get; set; } = string.Empty;
        [Required] [MaxLength(10)] public string ProductCode { get; set; } = string.Empty;
        public float Amount { get; set; }
    }
}
