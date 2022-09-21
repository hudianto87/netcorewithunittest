using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class Tput
    {
        public string? UnitHolderIdno { get; set; }
        public string? ProductCode { get; set; }
        public string? IddividendInvest { get; set; }
        public string? IdbankAccountIfPaidOut { get; set; }
        public string? AccountNoIfPaidOut { get; set; }

        public virtual TrefInvest? IddividendInvestNavigation { get; set; }
    }
}
