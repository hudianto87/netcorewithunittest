using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TproductOthersFee
    {
        public int IdProductOthersFee { get; set; }
        public string? ProductCode { get; set; }
        public DateTime? EntryDate { get; set; }
        public string? IdothersFee { get; set; }
        public double? FeeAmount { get; set; }
        public string? Remarks { get; set; }
    }
}
