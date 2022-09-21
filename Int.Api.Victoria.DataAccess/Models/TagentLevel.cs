using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TagentLevel
    {
        public TagentLevel()
        {
            TagentStructures = new HashSet<TagentStructure>();
            TagentTrees = new HashSet<TagentTree>();
            Tagents = new HashSet<Tagent>();
        }

        public int AgentLevelId { get; set; }
        public string AgentLevelName { get; set; } = null!;
        public byte CodeLength { get; set; }
        public bool IsCodeAuto { get; set; }
        public string SysCreatedBy { get; set; } = null!;
        public DateTime SysCreatedTime { get; set; }
        public string SysCreatedHost { get; set; } = null!;
        public string? SysModifiedBy { get; set; }
        public DateTime? SysModifiedTime { get; set; }
        public string? SysModifiedHost { get; set; }
        public byte? LevelType { get; set; }

        public virtual ICollection<TagentStructure> TagentStructures { get; set; }
        public virtual ICollection<TagentTree> TagentTrees { get; set; }
        public virtual ICollection<Tagent> Tagents { get; set; }
    }
}
