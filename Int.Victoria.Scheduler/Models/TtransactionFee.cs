using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TtransactionFee
    {
        public TtransactionFee()
        {
            TproductFeeByDates = new HashSet<TproductFeeByDate>();
            TproductTransactionFees = new HashSet<TproductTransactionFee>();
            TtransactionFeeDetails = new HashSet<TtransactionFeeDetail>();
        }

        public long TtransactionFeeId { get; set; }
        public string FeeCode { get; set; } = null!;
        public string FeeName { get; set; } = null!;
        public string TrxIdcategory { get; set; } = null!;
        public bool? IsActive { get; set; }
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

        public virtual ICollection<TproductFeeByDate> TproductFeeByDates { get; set; }
        public virtual ICollection<TproductTransactionFee> TproductTransactionFees { get; set; }
        public virtual ICollection<TtransactionFeeDetail> TtransactionFeeDetails { get; set; }
    }
}
