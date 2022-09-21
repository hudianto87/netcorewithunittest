using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TagentAuthContact
    {
        public int AgentAuthContactId { get; set; }
        public int AgentId { get; set; }
        public string FullName { get; set; } = null!;
        public string? Phone { get; set; }
        public bool? IsContact { get; set; }

        public virtual Tagent Agent { get; set; } = null!;
    }
}
