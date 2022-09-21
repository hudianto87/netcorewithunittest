using System.ComponentModel.DataAnnotations;

namespace Int.Api.Victoria.BusinessLayer.BindingModel
{
    public class BMHistoryTransaction
    {
        [Required][MaxLength(10)] public string ChannelID { get; set; } = string.Empty;
        [Required][MaxLength(16)] public string CIF { get; set; } = string.Empty;
        public DateTime? BeginDate { get; set; } = null;
        public DateTime? EndDate { get; set; } = null;
        [Required] public string Status { get; set; } = string.Empty;
    }
}
