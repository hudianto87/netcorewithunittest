using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TholdUnit
    {
        public long TholdUnitId { get; set; }
        public byte HoldType { get; set; }
        public long Idcustomer { get; set; }
        public long? IdsubAccount { get; set; }
        public long? OldTholdUnitId { get; set; }
        public double? Units { get; set; }
        public long? CollateralId { get; set; }
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

        public virtual TsubAccount? IdsubAccountNavigation { get; set; }
        public virtual TholdUnit? OldTholdUnit { get; set; }
        public virtual TholdUnit? InverseOldTholdUnit { get; set; }
    }
}
