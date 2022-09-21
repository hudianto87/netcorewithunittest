using System.ComponentModel.DataAnnotations;

namespace Int.Api.Victoria.BusinessLayer.BindingModel
{
    public class BMInqFeeTax
    {
        [Required] [MaxLength(10)] public string ChannelID { get; set; } = string.Empty;
        [Required] [MaxLength(16)] public string CIF { get; set; } = string.Empty;
        [Required] [MaxLength(10)] public string ProductCode { get; set; } = string.Empty;
        [Required] [MaxLength(10)] public string TransactionCategory { get; set; } = string.Empty;
        public List<TransactionValue> transactionValue { get; set; } = new List<TransactionValue>();
        [MaxLength(10)] public string ProductCodeTo { get; set; } = string.Empty;
        public int Tenor { get; set; }
    }
    public class TransactionValue
    {
        [MaxLength(100)]public string InvAccountNo { get; set; } = string.Empty;
        public double NetAmount { get; set; }
        public double Units { get; set; }
        public bool IsRedeemAll { get; set; }
    }
}