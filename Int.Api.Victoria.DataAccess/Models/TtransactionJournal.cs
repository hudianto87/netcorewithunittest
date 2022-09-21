using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TtransactionJournal
    {
        public long IdtransactionJournal { get; set; }
        public long? IdtransactionHistory { get; set; }
        public string ActionType { get; set; } = null!;
        public string AuditUser { get; set; } = null!;
        public DateTime AuditTime { get; set; }
        public string AuditHost { get; set; } = null!;
        public string? AuditRemarks { get; set; }
        public long Idtransaction { get; set; }
        public string? StatusBefore { get; set; }
        public string StatusAfter { get; set; } = null!;

        public virtual Ttransaction IdtransactionNavigation { get; set; } = null!;
    }
}
