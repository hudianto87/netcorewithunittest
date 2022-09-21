using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TmgtfeeHistoryStructure
    {
        public long TmgtfeeHistoryStructureId { get; set; }
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
        public long? TeamLeaderId { get; set; }
        public long? BranchManagerId { get; set; }
        public long? BranchId { get; set; }
        public long? DivisionId { get; set; }
        public double? SharingFee { get; set; }
    }
}
