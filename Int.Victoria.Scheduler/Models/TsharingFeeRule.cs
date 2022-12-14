using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TsharingFeeRule
    {
        public long FeeRuleId { get; set; }
        public long FeeId { get; set; }
        public short FeePos { get; set; }
        public string? Idstatus { get; set; }
        public string FeeSign { get; set; } = null!;
        public double? FeeRange { get; set; }
        public double? FeeAmount { get; set; }
        public string? FeeAmountCode { get; set; }
        public double? FeeRangeBottom { get; set; }
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

        public virtual TsharingFee Fee { get; set; } = null!;
        public virtual TrefStatus? IdstatusNavigation { get; set; }
    }
}
