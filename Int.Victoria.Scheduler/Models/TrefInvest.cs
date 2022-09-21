using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TrefInvest
    {
        public TrefInvest()
        {
            TdividendSaldos = new HashSet<TdividendSaldo>();
        }

        public string IddividendInvest { get; set; } = null!;
        public string DividendInvest { get; set; } = null!;

        public virtual ICollection<TdividendSaldo> TdividendSaldos { get; set; }
    }
}
