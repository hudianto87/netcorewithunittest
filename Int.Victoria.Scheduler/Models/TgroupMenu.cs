using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TgroupMenu
    {
        public TgroupMenu()
        {
            TgroupMenuLists = new HashSet<TgroupMenuList>();
        }

        public string GroupMenu { get; set; } = null!;
        public string Remark { get; set; } = null!;
        public string? ParentGroup { get; set; }

        public virtual ICollection<TgroupMenuList> TgroupMenuLists { get; set; }
    }
}
