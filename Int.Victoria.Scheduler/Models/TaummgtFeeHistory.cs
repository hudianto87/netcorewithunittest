using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TaummgtFeeHistory
    {
        public long TaummgtFeeHistoryId { get; set; }
        public DateTime FeeDate { get; set; }
        public long? IdtagentStructure { get; set; }
        public long? Idcustomer { get; set; }
        public long? Idproduct { get; set; }
        public DateTime? NavDate { get; set; }
        public DateTime? BalanceDate { get; set; }
        public decimal? OutStandingUnits { get; set; }
        public decimal? NavValue { get; set; }
        public decimal? Mgtfee { get; set; }
        public long? IdsubAccount { get; set; }
    }
}
