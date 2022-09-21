using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class Toutstanding
    {
        public string UnitHolderIdNo { get; set; } = null!;
        public string ProductCode { get; set; } = null!;
        public string IdTransaction { get; set; } = null!;
        public DateTime? Navdate { get; set; }
        public double? Units { get; set; }
    }
}
