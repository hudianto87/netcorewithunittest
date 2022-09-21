using System.ComponentModel.DataAnnotations;

namespace Int.Api.Victoria.BusinessLayer.BindingModel
{
    public class BMCustomerPortfolio
    {
        [Required][MaxLength(10)] public string ChannelID { get; set; } = string.Empty;
        [Required][MaxLength(16)] public string CIF { get; set; } = string.Empty;
        [MaxLength(20)] public string Category { get; set; } = string.Empty;
        [MaxLength(10)] public string ProductCode { get; set; } = string.Empty;
        public string BeginDate { get; set; } = string.Empty;
        public string EndDate { get; set; } = string.Empty;
    }
}
