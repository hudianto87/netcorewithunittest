using System.ComponentModel.DataAnnotations;

namespace Int.Api.Victoria.BusinessLayer.BindingModel
{
    public class BMTransaction
    {
        [Required][MaxLength(10)]public string ChannelID { get; set; } = string.Empty;
        [Required][MaxLength(16)] public string CIF { get; set; } = string.Empty;
        [Required][MaxLength(10)] public string ProductCode { get; set; } = string.Empty;
        [Required][MaxLength(10)] public string TransactionCategory { get; set; } = string.Empty;
        public List<TransAccountList> TransAccountLists { get; set; } = new List<TransAccountList>();
        public double Charges { get; set; }
        [MaxLength(50)] public string CustAccountNo { get; set; } = string.Empty;
        [MaxLength(10)] public string ProductCodeTo { get; set; } = string.Empty;
        [MaxLength(1024)] public string Remark { get; set; } = string.Empty;
        [MaxLength(50)] public string RefNo { get; set; } = string.Empty;
    }
    public class TransAccountList
    {
        [Required][MaxLength(100)] public string InAccountNo { get; set; } = string.Empty;
        public double NetAmount { get; set; }
        public double Units { get; set; }
        public bool IsRedeemAll { get; set; }
    }
}
