using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TrefCustAccountStatus
    {
        public short IdcustAcctStat { get; set; }
        public string CustomerAccountStatus { get; set; } = null!;
    }
}
