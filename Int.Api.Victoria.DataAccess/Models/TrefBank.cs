using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TrefBank
    {
        public TrefBank()
        {
            TautoDebitGroups = new HashSet<TautoDebitGroup>();
            TrefBankBranches = new HashSet<TrefBankBranch>();
        }

        public int Idbank { get; set; }
        public string BankName { get; set; } = null!;
        public string? Bicode { get; set; }
        public string? BimemberCode { get; set; }
        public string? ExternalCode { get; set; }
        public string? ExternalCode2 { get; set; }
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

        public virtual ICollection<TautoDebitGroup> TautoDebitGroups { get; set; }
        public virtual ICollection<TrefBankBranch> TrefBankBranches { get; set; }
    }
}
