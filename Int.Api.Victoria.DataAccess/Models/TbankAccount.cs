using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TbankAccount
    {
        public string Idbank { get; set; } = null!;
        public string? BranchName { get; set; }
        public string AccountNo { get; set; } = null!;
        public string? AccountName { get; set; }
        public string? Idcurrency { get; set; }
        public string? IdaccountBankType { get; set; }
    }
}
