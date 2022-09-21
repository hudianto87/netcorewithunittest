using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TproductDividendSchedule
    {
        public int PdscheduleId { get; set; }
        public string ProductCode { get; set; } = null!;
        public DateTime DividendDate { get; set; }
        public DateTime? AlertDate { get; set; }
        public double? DividendRate { get; set; }
        public string? DividendType { get; set; }
        public string? RecStatus { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool? TriggerApproval { get; set; }
        public bool? TriggerDeletion { get; set; }
    }
}
