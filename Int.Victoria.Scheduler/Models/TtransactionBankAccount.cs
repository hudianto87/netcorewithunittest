using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TtransactionBankAccount
    {
        public long IdtransactionBankAccount { get; set; }
        public long Idtransaction { get; set; }
        public short TransAccountType { get; set; }
        public string AccountNo { get; set; } = null!;
        public string? AccountName { get; set; }
        public int Idcurrency { get; set; }
        public int? IdbankBranch { get; set; }

        public virtual Ttransaction IdtransactionNavigation { get; set; } = null!;
    }
}
