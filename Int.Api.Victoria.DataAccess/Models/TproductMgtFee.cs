using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TproductMgtFee
    {
        public string? ProductCode { get; set; }
        public DateTime? MgtFeeDate { get; set; }
        public DateTime? Navdate { get; set; }
        public double? Navvalue { get; set; }
        public double? MgtFee { get; set; }
        public double? TotalNetAsset { get; set; }
    }
}
