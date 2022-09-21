using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class VUigenFixedTagentStructure
    {
        public long IdagentStructure { get; set; }
        public DateTime? EffDate { get; set; }
        public string AgentTreeCode { get; set; } = null!;
        public string CustomerTreeCode { get; set; } = null!;
        public int? AgentId { get; set; }
        public string? NameAgent { get; set; }
        public long? Idcustomer { get; set; }
        public int? IsIncludeAum { get; set; }
        public string SysCreatedBy { get; set; } = null!;
        public DateTime SysCreatedTime { get; set; }
        public string SysCreatedHost { get; set; } = null!;
        public string? SysmodifiedBy { get; set; }
        public DateTime? SysModifiedTime { get; set; }
        public string? SysModifiedHost { get; set; }
        public string SysActionType { get; set; } = null!;
        public int SysApprovalStatus { get; set; }
        public int SysRecStatus { get; set; }
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
