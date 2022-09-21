using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TproductGroup
    {
        public TproductGroup()
        {
            TproductGroupLists = new HashSet<TproductGroupList>();
        }

        public int GroupId { get; set; }
        public string? GroupName { get; set; }
        public int? ParentId { get; set; }

        public virtual ICollection<TproductGroupList> TproductGroupLists { get; set; }
    }
}
