using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class Kpiachievement
    {
        public long Idkpiachievement { get; set; }
        public string? Kpiachievement1 { get; set; }
        public double? IncentiveTier { get; set; }
        public double? SocialInsuranceTier { get; set; }
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
    }
}
