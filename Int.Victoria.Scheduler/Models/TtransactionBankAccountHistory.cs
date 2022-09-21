using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TtransactionBankAccountHistory
    {
        public long IdtransactionBankAccountHistory { get; set; }
        public long IdtransactionHistory { get; set; }
        public string SysActionType { get; set; } = null!;
        public string AuditUser { get; set; } = null!;
        public DateTime AuditTime { get; set; }
        public string AuditHost { get; set; } = null!;
        public string? AuditRemarks { get; set; }
        public long IdtransactionBankAccount { get; set; }
        public long Idtransaction { get; set; }
        public short TransAccountType { get; set; }
        public string AccountNo { get; set; } = null!;
        public string? AccountName { get; set; }
        public int Idcurrency { get; set; }
        public int? IdbankBranch { get; set; }

        public virtual TtransactionHistory IdtransactionHistoryNavigation { get; set; } = null!;
    }
}
