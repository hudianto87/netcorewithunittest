using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TgroupCust
    {
        public TgroupCust()
        {
            TgroupCustLists = new HashSet<TgroupCustList>();
        }

        public string GroupCust { get; set; } = null!;
        public string Remark { get; set; } = null!;
        public string? ParentGroup { get; set; }

        public virtual ICollection<TgroupCustList> TgroupCustLists { get; set; }
    }
}
