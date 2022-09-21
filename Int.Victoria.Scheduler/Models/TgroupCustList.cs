using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TgroupCustList
    {
        public string GroupCust { get; set; } = null!;
        public string CodeAgent { get; set; } = null!;
        public bool? IsEnabled { get; set; }
        public bool IsMain { get; set; }

        public virtual TgroupCust GroupCustNavigation { get; set; } = null!;
    }
}
