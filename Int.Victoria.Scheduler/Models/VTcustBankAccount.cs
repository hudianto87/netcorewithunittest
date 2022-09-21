using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class VTcustBankAccount
    {
        public int IdcustBankAccount { get; set; }
        public long Idcustomer { get; set; }
        public string AccountNo { get; set; } = null!;
        public string AccountName { get; set; } = null!;
        public string? CurrencyCode { get; set; }
        public string? BankName { get; set; }
        public string? BranchName { get; set; }
        public string? AccountBankType { get; set; }
    }
}
