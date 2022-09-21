using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class Tcoupon
    {
        public string ProductCode { get; set; } = null!;
        public int Couponseq { get; set; }
        public string? Interval { get; set; }
        public DateTime? RateDate { get; set; }
        public DateTime? PaymentDate { get; set; }
        public double? CouponRate { get; set; }
    }
}
