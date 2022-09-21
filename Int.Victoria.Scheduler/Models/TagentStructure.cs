using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TagentStructure
    {
        public TagentStructure()
        {
            InverseIdagentStructureParentNavigation = new HashSet<TagentStructure>();
            InverseOldIdagentStructureNavigation = new HashSet<TagentStructure>();
        }

        public long IdagentStructure { get; set; }
        public long? IdagentStructureParent { get; set; }
        public DateTime EffDate { get; set; }
        public long ShellId { get; set; }
        public int? AgentId { get; set; }
        public int AgentLevelId { get; set; }
        public string? TreeCodeParent { get; set; }
        public string? TreeCode { get; set; }
        public string TreeCode2 { get; set; } = null!;
        public int LastChildIndex { get; set; }
        public long? OldIdagentStructure { get; set; }
        public bool IsResign { get; set; }
        public DateTime? SaldoDateBegin { get; set; }
        public DateTime? SaldoDateEnd { get; set; }
        public bool? IsActive { get; set; }
        public string? Remarks { get; set; }
        public string SysCreatedBy { get; set; } = null!;
        public DateTime SysCreatedTime { get; set; }
        public string SysCreatedHost { get; set; } = null!;
        public string? SysModifiedBy { get; set; }
        public DateTime? SysModifiedTime { get; set; }
        public string? SysModifiedHost { get; set; }
        public string SysActionType { get; set; } = null!;
        public byte SysApprovalStatus { get; set; }
        public bool? SysRecStatus { get; set; }
        public string? SysPendingBy { get; set; }
        public DateTime? SysPendingTime { get; set; }
        public string? SysPendingHost { get; set; }
        public string? SysApprovalNotes { get; set; }
        public string? SysApprovedBy { get; set; }
        public DateTime? SysApprovedTime { get; set; }
        public string? SysApprovedHost { get; set; }
        public string? SysDeletedBy { get; set; }
        public DateTime? SysDeletedTime { get; set; }
        public string? SysDeletedHost { get; set; }
        public long IdagentStructureJournal { get; set; }

        public virtual TagentLevel AgentLevel { get; set; } = null!;
        public virtual TagentStructureJournal IdagentStructureJournalNavigation { get; set; } = null!;
        public virtual TagentStructure? IdagentStructureParentNavigation { get; set; }
        public virtual TagentStructure? OldIdagentStructureNavigation { get; set; }
        public virtual ICollection<TagentStructure> InverseIdagentStructureParentNavigation { get; set; }
        public virtual ICollection<TagentStructure> InverseOldIdagentStructureNavigation { get; set; }
    }
}
