using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TtempRptsharingFee
    {
        public string? Id { get; set; }
        public string? Product { get; set; }
        public string? Ccy { get; set; }
        public double? Nav { get; set; }
        public double? TotalFee { get; set; }
        public double? TotalAgent { get; set; }
        public double? TotalOther { get; set; }
        public double? TotalNetDim { get; set; }
    }
}
