using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TproductTransfer
    {
        public string ProductCode { get; set; } = null!;
        public string Idcategory { get; set; } = null!;
        public byte? DealDateAdd { get; set; }
        public byte? SettleDateAdd { get; set; }
    }
}
