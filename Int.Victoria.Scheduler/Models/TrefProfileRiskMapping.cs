using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TrefProfileRiskMapping
    {
        public string RiskProfileNasabah { get; set; } = null!;
        public string RiskProfileProduct { get; set; } = null!;
        public byte Flag { get; set; }
    }
}
