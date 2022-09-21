using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TviolationMapping
    {
        public int TviolationMappingId { get; set; }
        public int TviolationId { get; set; }
        public int JobId { get; set; }
        public int TviolationRefId { get; set; }
        public string InvestorType { get; set; } = null!;

        public virtual Tviolation TviolationRef { get; set; } = null!;
    }
}
