using System.ComponentModel.DataAnnotations;

namespace Int.Api.Victoria.BusinessLayer.BindingModelResult
{
    public class BMRInqFeeTax
    {
        [Required][MaxLength(16)] public string CIF { get; set; } = string.Empty;
        [Required][MaxLength(10)] public string ProductCode { get; set; } = string.Empty;
        [Required][MaxLength(10)] public string TransactionCategory { get; set; } = string.Empty;
        public double NAVPerUnit { get; set; }
        [Required] public DateTime NAVDate { get; set; }
        [Required] public double TotalNetAmount { get; set; }
        [Required] public double TotalFeeAmount { get; set; }
        [Required] public double TotalTaxAmount { get; set; }
        [Required] public double TotalAmount { get; set; }
        public List<TaxFeeListOut> TaxFeeListOut { get; set; } = new List<TaxFeeListOut>();
        [Required][MaxLength(3)] public string Currency { get; set; } = string.Empty;
        [Required][MaxLength(50)] public string CustBankAccountNo { get; set; } = string.Empty;
        [MaxLength(10)] public string ProductCodeTo { get; set; } = string.Empty;
        [Required][MaxLength(50)] public string ProdBankAccountNo { get; set; } = string.Empty;
        [Required] public bool IsAfter { get; set; }
    }
    public class TaxFeeListOut
    {
        [MaxLength(100)] public string InvAccountNo { get; set; } = string.Empty;
        [Required] public double Amount { get; set; }
        [Required] public double NetAmount { get; set; }
        [Required] public double FeePercentage { get; set; }
        [Required] public double FeeAmount { get; set; }
        [Required] public double TaxPercentage { get; set; }
        [Required] public double TaxAmount { get; set; }
    }
}