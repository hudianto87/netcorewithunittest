using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TsharingFeeHistory
    {
        public long TshraingFeeHistoryId { get; set; }
        public DateTime FeeDate { get; set; }
        public long SubAccountId { get; set; }
        public long? ProductId { get; set; }
        public DateTime? Navdate { get; set; }
        public DateTime? BalanceDate { get; set; }
        public decimal? NavValue { get; set; }
        public decimal? BalanceUnits { get; set; }
        public double? SharingFee { get; set; }
        public long? AgentId { get; set; }
    }
}
