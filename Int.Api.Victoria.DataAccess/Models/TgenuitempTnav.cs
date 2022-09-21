using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TgenuitempTnav
    {
        public long TgenuitempTableId { get; set; }
        public string TgenuitempSessionId { get; set; } = null!;
        public long? TgenuitempIdmaster { get; set; }
        public long? TgenuitempIddetail { get; set; }
        public short TgenuitempChangeFlag { get; set; }
        public string TgenuitempSysCreatedBy { get; set; } = null!;
        public DateTime TgenuitempSysCreatedTime { get; set; }
        public string TgenuitempSysCreatedHost { get; set; } = null!;
        public string? TgenuitempSysModifiedBy { get; set; }
        public DateTime? TgenuitempSysModifiedTime { get; set; }
        public string? TgenuitempSysModifiedHost { get; set; }
        public long? Idnav { get; set; }
        public long? Idproduct { get; set; }
        public DateTime? Navdate { get; set; }
        public double? Value { get; set; }
        public double? DividendRate { get; set; }
        public double? Multiplier { get; set; }
        public double? Price { get; set; }
        public double? DistributionUnit { get; set; }
        public double? Ihsg { get; set; }
        public double? Total { get; set; }
        public double? TotalNetAsset { get; set; }
        public int? NoUhactive { get; set; }
        public int? NoUhtotal { get; set; }
        public double? OutstandingUnit { get; set; }
        public double? TotalMfee { get; set; }
        public double? BtaxRevenue { get; set; }
        public double? ClosingBalance { get; set; }
        public long? RecordNum { get; set; }
        public string? FwPrefix { get; set; }
        public DateTime? FwTimeStamp { get; set; }
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
    }
}
