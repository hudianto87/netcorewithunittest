using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TgenuipendTagentStructure
    {
        public long IdagentStructure { get; set; }
        public long? IdagentStructureParent { get; set; }
        public DateTime? EffDate { get; set; }
        public long? ShellId { get; set; }
        public int? AgentId { get; set; }
        public int? AgentLevelId { get; set; }
        public string? TreeCodeParent { get; set; }
        public string? TreeCode { get; set; }
        public string? TreeCode2 { get; set; }
        public int? LastChildIndex { get; set; }
        public long? OldIdagentStructure { get; set; }
        public bool? IsResign { get; set; }
        public DateTime? SaldoDateBegin { get; set; }
        public DateTime? SaldoDateEnd { get; set; }
        public bool? IsActive { get; set; }
        public string? Remarks { get; set; }
        public string? SysCreatedBy { get; set; }
        public DateTime? SysCreatedTime { get; set; }
        public string? SysCreatedHost { get; set; }
        public string? SysModifiedBy { get; set; }
        public DateTime? SysModifiedTime { get; set; }
        public string? SysModifiedHost { get; set; }
        public string? SysActionType { get; set; }
        public byte? SysApprovalStatus { get; set; }
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
        public long? IdagentStructureJournal { get; set; }
    }
}
