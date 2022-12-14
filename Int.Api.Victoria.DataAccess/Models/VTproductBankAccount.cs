using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class VTproductBankAccount
    {
        public int IdproductBankAccount { get; set; }
        public long Idproduct { get; set; }
        public string AccountNo { get; set; } = null!;
        public string AccountName { get; set; } = null!;
        public string? CurrencyCode { get; set; }
        public string? BankName { get; set; }
        public string? BranchName { get; set; }
        public string? AccountBankType { get; set; }
    }
}
