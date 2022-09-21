using System.ComponentModel.DataAnnotations;

namespace Int.Api.Victoria.BusinessLayer.BindingModelResult
{
    public class BMRInqCustBankAccount
    {
        [Required] [MaxLength(10)] public string CIF { get; set; } = string.Empty;
        public List<BankAccountList> BankAccounts { get; set; }
    }
    public class BankAccountList
    {
        [MaxLength(50)] public string AccountNo { get; set; } = string.Empty;
        [MaxLength(255)] public string AccountName { get; set; } = string.Empty;
        [MaxLength(100)] public string AccountType { get; set; } = string.Empty;
        [MaxLength(10)] public string Currency { get; set; } = string.Empty;
        [MaxLength(50)] public string BankName { get; set; } = string.Empty;
        [MaxLength(50)] public string BranchName { get; set; } = string.Empty;
    }
}
