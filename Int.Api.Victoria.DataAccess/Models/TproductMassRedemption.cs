using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TproductMassRedemption
    {
        public string ProductCode { get; set; } = null!;
        public int SeqNo { get; set; }
        public DateTime MassRedDate { get; set; }
        public DateTime? AlertDate { get; set; }
        public string? RecStatus { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
