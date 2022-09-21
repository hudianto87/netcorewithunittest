using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TassetClass
    {
        public long TassetClassId { get; set; }
        public long TproductCategoryId { get; set; }
        public long AssetCategory { get; set; }
        public int? RiskScore { get; set; }
        public double? RiskRate { get; set; }
        public double? ExpectedReturn { get; set; }
        public long? InflationPerformance { get; set; }
        public long? RupiahPerformance { get; set; }
        public long? Gdpperformance { get; set; }
        public double? InflationPerformanceIncDec { get; set; }
        public double? RupiahPerformanceIncDec { get; set; }
        public double? GdpperformanceIncDec { get; set; }
        public string? Remark { get; set; }
        public bool? IsActive { get; set; }
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
