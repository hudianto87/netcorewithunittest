using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TprodCustodian
    {
        public int CustodianId { get; set; }
        public string? CustodianName { get; set; }
        public string? Notes { get; set; }
    }
}
