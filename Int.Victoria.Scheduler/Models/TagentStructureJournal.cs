using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TagentStructureJournal
    {
        public TagentStructureJournal()
        {
            TagentStructures = new HashSet<TagentStructure>();
        }

        public long IdagentStructureJournal { get; set; }
        public string? Remarks { get; set; }
        public DateTime? DateJournal { get; set; }
        public string SysCreatedBy { get; set; } = null!;
        public DateTime SysCreatedTime { get; set; }
        public string SysCreatedHost { get; set; } = null!;

        public virtual ICollection<TagentStructure> TagentStructures { get; set; }
    }
}
