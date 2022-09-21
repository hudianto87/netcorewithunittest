using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TcouponFreq
    {
        public int TcouponFreqId { get; set; }
        public string CouponFreqCode { get; set; } = null!;
        public string? Description { get; set; }
        public int Frequency { get; set; }
    }
}
