using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TagentGroupList
    {
        public int GroupId { get; set; }
        public string CodeAgent { get; set; } = null!;
        public int? SeqNo { get; set; }

        public virtual TagentGroup Group { get; set; } = null!;
    }
}
