using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TtransactionForApproval
    {
        public string Idtransaction { get; set; } = null!;
        public string ApproveUser { get; set; } = null!;
        public short? RecType { get; set; }
    }
}
