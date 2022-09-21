using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TcouponFreq
    {
        public int TcouponFreqId { get; set; }
        public string CouponFreqCode { get; set; } = null!;
        public string? Description { get; set; }
        public int Frequency { get; set; }
    }
}
