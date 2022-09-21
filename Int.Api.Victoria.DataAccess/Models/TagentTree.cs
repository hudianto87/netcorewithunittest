using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TagentTree
    {
        public TagentTree()
        {
            InverseIdagentTreeParentNavigation = new HashSet<TagentTree>();
            TagentTreeAgents = new HashSet<TagentTreeAgent>();
        }

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

        public virtual TagentLevel AgentLevel { get; set; } = null!;
        public virtual TagentTree? IdagentTreeParentNavigation { get; set; }
        public virtual ICollection<TagentTree> InverseIdagentTreeParentNavigation { get; set; }
        public virtual ICollection<TagentTreeAgent> TagentTreeAgents { get; set; }
    }
}
