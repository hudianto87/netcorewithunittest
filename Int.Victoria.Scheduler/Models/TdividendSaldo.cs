using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TdividendSaldo
    {
        public string ProductCode { get; set; } = null!;
        public DateTime DividendDate { get; set; }
        public string UnitHolderIdno { get; set; } = null!;
        public double? SaldoStart { get; set; }
        public double? AmountDiv { get; set; }
        public double? UnitDiv { get; set; }
        public string? IddividendInvest { get; set; }
        public bool? IsPosted { get; set; }
        public string? AccountNo { get; set; }
        public string? AccountName { get; set; }
        public int? IdBankBranch { get; set; }
        public string? IdBank { get; set; }
        public string? IdAccountBankType { get; set; }
        public string? IdCurrency { get; set; }

        public virtual TrefInvest? IddividendInvestNavigation { get; set; }
        public virtual Tdividend Tdividend { get; set; } = null!;
    }
}
