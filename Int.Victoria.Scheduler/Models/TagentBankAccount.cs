using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TagentBankAccount
    {
        public long IdagentBankAccount { get; set; }
        public int AgentId { get; set; }
        public int? IdbankBranch { get; set; }
        public int? IdaccountBankType { get; set; }
        public int Idcurrency { get; set; }
        public string AccountNo { get; set; } = null!;
        public string AccountName { get; set; } = null!;
        public bool IsMandatory { get; set; }
        public bool? IsPriority { get; set; }
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

        public virtual Tagent Agent { get; set; } = null!;
        public virtual TrefAccountBankType? IdaccountBankTypeNavigation { get; set; }
        public virtual TrefBankBranch? IdbankBranchNavigation { get; set; }
        public virtual TrefCurrency IdcurrencyNavigation { get; set; } = null!;
    }
}
