using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TrefKotaNew
    {
        public TrefKotaNew()
        {
            InverseParentCodeNavigation = new HashSet<TrefKotaNew>();
        }

        public string KodeKota { get; set; } = null!;
        public string? No { get; set; }
        public string Prop { get; set; } = null!;
        public string? Ibukota { get; set; }
        public string? PostalCode { get; set; }
        public string? ParentCode { get; set; }
        public string? AltValue1 { get; set; }
        public string? AltValue2 { get; set; }
        public string? AltValue3 { get; set; }

        public virtual TrefKotaNew? ParentCodeNavigation { get; set; }
        public virtual ICollection<TrefKotaNew> InverseParentCodeNavigation { get; set; }
    }
}
