using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TdistributedIncomeDatum
    {
        public long TdistributedIncomeDataId { get; set; }
        public short Type { get; set; }
        public long Idproduct { get; set; }
        public DateTime CumDate { get; set; }
        public DateTime ExDate { get; set; }
        public DateTime? PaymentDate { get; set; }
        public double? DistributedIncomePerUnit { get; set; }
        public double DistributedIncomePolicy { get; set; }
        public short DistributedIncomeNo { get; set; }
        public DateTime? InputDate { get; set; }
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
