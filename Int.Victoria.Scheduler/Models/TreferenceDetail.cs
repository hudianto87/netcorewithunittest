using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TreferenceDetail
    {
        public long TreferenceDetailId { get; set; }
        public long TreferenceGroupId { get; set; }
        public string MainValue { get; set; } = null!;
        public string? AltValue1 { get; set; }
        public string? AltValue2 { get; set; }
        public string? AltValue3 { get; set; }
        public string? AltValue4 { get; set; }
        public string? AltValue5 { get; set; }
        public string? AltValue6 { get; set; }
        public string Display { get; set; } = null!;
        public int? DisplayOrder { get; set; }
        public string? DisplayId { get; set; }
        public int? DisplayOrderId { get; set; }
        public string? DisplayEn { get; set; }
        public int? DisplayOrderEn { get; set; }
        public string? Remarks { get; set; }
        public string SysCreatedBy { get; set; } = null!;
        public DateTime SysCreatedTime { get; set; }
        public string SysCreatedHost { get; set; } = null!;
        public string? SysModifiedBy { get; set; }
        public DateTime? SysModifiedTime { get; set; }
        public string? SysModifiedHost { get; set; }
        public byte? SysApprovalStatus { get; set; }
        public string? SysActionType { get; set; }
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

        public virtual TreferenceGroup TreferenceGroup { get; set; } = null!;
    }
}
