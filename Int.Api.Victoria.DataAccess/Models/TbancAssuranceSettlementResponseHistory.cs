using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TbancAssuranceSettlementResponseHistory
    {
        public long IdbancAssuranceSettlementResponseHistory { get; set; }
        public string? RekeningTujuan { get; set; }
        public string? PolisNo { get; set; }
        public string? BulanData { get; set; }
        public string? Nominal { get; set; }
        public string? RekeningDebit { get; set; }
        public string? StatusTrans { get; set; }
        public string? KodeBiller { get; set; }
        public DateTime? TransDate { get; set; }
        public string SysCreatedBy { get; set; } = null!;
        public DateTime? SysCreatedTime { get; set; }
        public string SysCreatedHost { get; set; } = null!;
    }
}
