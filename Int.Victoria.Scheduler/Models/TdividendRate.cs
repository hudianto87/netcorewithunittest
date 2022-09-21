using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TdividendRate
    {
        public decimal? MfId { get; set; }
        public decimal DrId { get; set; }
        public decimal? DrValue { get; set; }
        public DateTime? DrDate { get; set; }
        public decimal? DrStatus { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? SupervisorId { get; set; }
        public Guid Rowguid { get; set; }
    }
}
