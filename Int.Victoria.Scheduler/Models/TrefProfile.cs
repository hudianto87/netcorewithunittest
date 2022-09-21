using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TrefProfile
    {
        public TrefProfile()
        {
            Tcustomers = new HashSet<Tcustomer>();
            Tproducts = new HashSet<Tproduct>();
        }

        public int ProfileId { get; set; }
        public string? ProfileName { get; set; }
        public int? MinValue { get; set; }
        public int? MaxValue { get; set; }
        public string? Description { get; set; }
        public string? ProfileShortName { get; set; }
        public int? SeqNo { get; set; }
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

        public virtual ICollection<Tcustomer> Tcustomers { get; set; }
        public virtual ICollection<Tproduct> Tproducts { get; set; }
    }
}
