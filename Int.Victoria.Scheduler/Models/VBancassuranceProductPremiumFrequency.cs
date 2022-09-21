using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class VBancassuranceProductPremiumFrequency
    {
        public string ProductCode { get; set; } = null!;
        public string Label { get; set; } = null!;
        public int Value { get; set; }
    }
}
