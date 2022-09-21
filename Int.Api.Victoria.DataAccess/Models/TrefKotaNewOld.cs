using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TrefKotaNewOld
    {
        public string KodeKota { get; set; } = null!;
        public string? No { get; set; }
        public string Prop { get; set; } = null!;
        public string? Ibukota { get; set; }
        public string? PostalCode { get; set; }
        public string? ParentCode { get; set; }
        public string? AltValue1 { get; set; }
        public string? AltValue2 { get; set; }
        public string? AltValue3 { get; set; }
    }
}
