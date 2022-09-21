using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TcustomerCif
    {
        public string UnitHolderIdno { get; set; } = null!;
        public string? Cifno { get; set; }
        public int? Idcustomer { get; set; }
    }
}
