using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class Tnavtemporary
    {
        public string ProductCode { get; set; } = null!;
        public DateTime Navdate { get; set; }
        public double? Value { get; set; }
        public double? Multiplier { get; set; }
        public double? Price { get; set; }
        public double? DistributionUnit { get; set; }
        public double? Ihsg { get; set; }
        public double? Total { get; set; }
        public double? TotalNetAsset { get; set; }
        public int? NoUhactive { get; set; }
        public int? NoUhtotal { get; set; }
        public double? OutstandingUnit { get; set; }
        public double? TotalMfee { get; set; }
        public double? BtaxRevenue { get; set; }
        public double? ClosingBalance { get; set; }
        public int RecordNum { get; set; }
    }
}
