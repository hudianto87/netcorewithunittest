using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TagentTreeBackup
    {
        public long IdagentTree { get; set; }
        public long? IdagentTreeParent { get; set; }
        public int AgentLevelId { get; set; }
        public string? TreeCodeParent { get; set; }
        public string? TreeCode { get; set; }
        public string TreeCode2 { get; set; } = null!;
        public int LastChildIndex { get; set; }
        public DateTime EffDate { get; set; }
        public byte RecStatus { get; set; }
        public DateTime RecCreated { get; set; }
        public string RecCreator { get; set; } = null!;
        public DateTime? RecEdited { get; set; }
        public string? RecEditor { get; set; }
    }
}
