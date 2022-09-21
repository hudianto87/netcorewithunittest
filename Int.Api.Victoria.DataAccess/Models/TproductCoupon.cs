using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TproductCoupon
    {
        public string ProductCode { get; set; } = null!;
        public DateTime CouponDate { get; set; }
        public double? CouponRate { get; set; }
        public string? CouponType { get; set; }
    }
}
