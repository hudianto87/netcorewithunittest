using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class VTrefKotaNewProvince
    {
        public string KodeKota { get; set; } = null!;
        public string? No { get; set; }
        public string Prop { get; set; } = null!;
        public string? Ibukota { get; set; }
        public string? PostalCode { get; set; }
        public string? ParentCode { get; set; }
    }
}
