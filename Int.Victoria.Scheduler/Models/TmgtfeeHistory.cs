using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TmgtfeeHistory
    {
        public long TmgtfeeHistoryId { get; set; }
        public DateTime FeeDate { get; set; }
        public long SubAccountId { get; set; }
        public long? ProductId { get; set; }
        public DateTime? Navdate { get; set; }
        public DateTime? BalanceDate { get; set; }
        public decimal? NavValue { get; set; }
        public decimal? OutstandingUnits { get; set; }
        public long? DateDiff { get; set; }
        public decimal? Mgtfee { get; set; }
        public long? AgentId { get; set; }
        public double? SharingFee { get; set; }
    }
}
