using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TproductPoFtype
    {
        public byte PoFtypeId { get; set; }
        public string? PoFtypeName { get; set; }
        public string ProductCode { get; set; } = null!;
        public string? PeriodType { get; set; }
        public int? Period { get; set; }
        public double? TargetRate { get; set; }
        public double? PenaltyRate { get; set; }
        public string? IntDaysCode { get; set; }
    }
}
