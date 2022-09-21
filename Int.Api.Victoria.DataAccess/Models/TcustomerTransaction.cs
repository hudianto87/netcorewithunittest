using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TcustomerTransaction
    {
        public string UnitHolderIdno { get; set; } = null!;
        public string? ProductCode { get; set; }
        public int? Idcustomer { get; set; }
        public int? Idproduct { get; set; }
    }
}
