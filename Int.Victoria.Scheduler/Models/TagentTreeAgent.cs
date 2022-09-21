using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TagentTreeAgent
    {
        public long IdagentTree { get; set; }
        public DateTime EffDate { get; set; }
        public int? AgentId { get; set; }

        public virtual Tagent? Agent { get; set; }
        public virtual TagentTree IdagentTreeNavigation { get; set; } = null!;
    }
}
