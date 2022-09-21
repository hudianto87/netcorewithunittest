using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TproductQuotum
    {
        public DateTime NavDate { get; set; }
        public double QuotaValue { get; set; }
        public double? QuotaNextDay { get; set; }
    }
}
