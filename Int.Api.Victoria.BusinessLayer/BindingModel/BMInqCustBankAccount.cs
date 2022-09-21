using System.ComponentModel.DataAnnotations;

namespace Int.Api.Victoria.BusinessLayer.BindingModel
{
    public class BMInqCustBankAccount
    {
        [Required] [MaxLength(10)] public string ChannelID { get; set; } = string.Empty;
        [Required] [MaxLength(16)] public string CIF { get; set; } = string.Empty;
    }
}