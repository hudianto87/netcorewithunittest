using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class VLookupAgent
    {
        public string? TreeCode2 { get; set; }
        public long? IdagentTree { get; set; }
        public int AgentId { get; set; }
        public string? NameAgent { get; set; }
        public DateTime? EffDate { get; set; }
        public int AgentLevelId { get; set; }
        public string? AgentLevelName { get; set; }
        public long? IdagentTreeParent { get; set; }
    }
}
