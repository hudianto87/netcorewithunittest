using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TagentTreeAgentBackup
    {
        public long IdagentTree { get; set; }
        public DateTime EffDate { get; set; }
        public int? AgentId { get; set; }
    }
}
