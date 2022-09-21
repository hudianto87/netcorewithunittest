using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TproductFee
    {
        public int IdproductFee { get; set; }
        public long Idproduct { get; set; }
        public string Type { get; set; } = null!;
        public short Pos { get; set; }
        public string? PfolioCode { get; set; }
        public double FeeAmount { get; set; }
        public string FeeAmountCode { get; set; } = null!;
        public string FeeSign { get; set; } = null!;
        public double FeePeriod { get; set; }
        public short FeeMonth { get; set; }
        public int DayPerYear { get; set; }
        public DateTime? DateUpdate { get; set; }
        public decimal FeeRange { get; set; }
        public string? SignMonth { get; set; }
        public int PeriodMonth { get; set; }
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

        public virtual Tproduct IdproductNavigation { get; set; } = null!;
    }
}
