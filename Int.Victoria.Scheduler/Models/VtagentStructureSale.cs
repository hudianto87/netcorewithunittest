using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class VtagentStructureSale
    {
        public int? AgentId { get; set; }
        public string? CodeAgent { get; set; }
        public string? NameAgent { get; set; }
        public DateTime EffDate { get; set; }
        public int? Idcustomer { get; set; }
        public long IdagentStructure { get; set; }
        public long ShellId { get; set; }
        public bool SysRecStatus { get; set; }
        public string SysCreatedBy { get; set; } = null!;
        public DateTime SysCreatedTime { get; set; }
        public string SysCreatedHost { get; set; } = null!;
        public string? SysModifiedBy { get; set; }
        public DateTime? SysModifiedTime { get; set; }
        public string? SysModifiedHost { get; set; }
        public string SysActionType { get; set; } = null!;
        public byte SysApprovalStatus { get; set; }
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
    }
}
