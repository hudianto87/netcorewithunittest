using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class VTcustomerPending
    {
        public long Rowid { get; set; }
        public long? Idcustomer { get; set; }
        public string? InvestorType { get; set; }
        public string? UnitHolderIdno { get; set; }
        public string? Sid { get; set; }
        public string? FundUnitAccount { get; set; }
    }
}
