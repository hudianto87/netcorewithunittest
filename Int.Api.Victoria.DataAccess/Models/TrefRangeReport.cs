using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TrefRangeReport
    {
        public int RangeId { get; set; }
        public string? RangeType { get; set; }
        public string? RangeName { get; set; }
        public double? Min { get; set; }
        public double? Max { get; set; }
        public int? Sequence { get; set; }
    }
}
