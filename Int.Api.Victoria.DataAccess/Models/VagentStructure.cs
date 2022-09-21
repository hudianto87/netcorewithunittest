using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class VagentStructure
    {
        public int? AgentId { get; set; }
        public string? CodeAgent { get; set; }
        public string? ParentAgent { get; set; }
        public string? NameAgent { get; set; }
        public string? OtherNameAgent { get; set; }
        public long IdagentStructure { get; set; }
        public long? IdagentStructureParent { get; set; }
        public DateTime EffDate { get; set; }
        public int AgentLevelId { get; set; }
        public long? OldIdagentStructure { get; set; }
        public bool IsResign { get; set; }
        public DateTime? SaldoDateBegin { get; set; }
        public DateTime? SaldoDateEnd { get; set; }
        public bool IsActive { get; set; }
        public string? Remarks { get; set; }
        public string SysCreatedBy { get; set; } = null!;
        public DateTime SysCreatedTime { get; set; }
        public string SysCreatedHost { get; set; } = null!;
        public string? SysModifiedBy { get; set; }
        public DateTime? SysModifiedTime { get; set; }
        public string? SysModifiedHost { get; set; }
        public string SysActionType { get; set; } = null!;
        public byte SysApprovalStatus { get; set; }
        public bool SysRecStatus { get; set; }
        public string? SysPendingBy { get; set; }
        public DateTime? SysPendingTime { get; set; }
        public string? SysPendingHost { get; set; }
        public string? SysApprovalNotes { get; set; }
        public string? SysApprovedBy { get; set; }
        public string? SysApprovedHost { get; set; }
        public DateTime? SysApprovedTime { get; set; }
        public string? SysDeletedBy { get; set; }
        public DateTime? SysDeletedTime { get; set; }
        public string? SysDeletedHost { get; set; }
        public string? TreeCodeParent { get; set; }
        public string? TreeCode { get; set; }
        public string TreeCode2 { get; set; } = null!;
        public int LastChildIndex { get; set; }
    }
}
