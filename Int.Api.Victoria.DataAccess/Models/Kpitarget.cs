using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class Kpitarget
    {
        public long Idkpitarget { get; set; }
        public double Ncf { get; set; }
        public double AdditionalRevenue { get; set; }
        public int ActiveAccount { get; set; }
        public double TotalRevenue { get; set; }
        public double Qualitative { get; set; }
        public string SysCreatedBy { get; set; } = null!;
        public DateTime SysCreatedTime { get; set; }
        public string SysCreatedHost { get; set; } = null!;
        public string? SysModifiedBy { get; set; }
        public DateTime? SysModifiedTime { get; set; }
        public string? SysModifiedHost { get; set; }
        public string? SysActionType { get; set; }
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
        public long? Idsales { get; set; }
        public double? WeightNcf { get; set; }
        public double? TargetNcf { get; set; }
        public double? WeightRevenue { get; set; }
        public double? TargetRevenue { get; set; }
        public double? WeightActiveAccount { get; set; }
        public double? TargetActiveAccount { get; set; }
        public double? WeightQualitative { get; set; }
        public double? TargetQualitative { get; set; }
    }
}
