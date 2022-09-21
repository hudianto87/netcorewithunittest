using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TagentFee
    {
        public string CodeAgent { get; set; } = null!;
        public string Type { get; set; } = null!;
        public short Pos { get; set; }
        public double? FeeAmount { get; set; }
        public string? FeeAmountCode { get; set; }
        public string? FeeSign { get; set; }
        public string? FeePeriod { get; set; }
        public short? FeeMonth { get; set; }
        public int? DayPerYear { get; set; }
        public DateTime? DateUpdate { get; set; }
        public double? FeeRange { get; set; }
    }
}
