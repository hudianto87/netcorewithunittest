using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TextCimbBatchLogDebitFail
    {
        public long TextCimbBatchLogDebitFailId { get; set; }
        public long? Idtransaction { get; set; }
        public long? Idcustomer { get; set; }
        public long? IdcustomerRegInvestmentPlan { get; set; }
        public DateTime? Date { get; set; }
        public string? Remarks { get; set; }
        public DateTime? CreatedTime { get; set; }
    }
}
