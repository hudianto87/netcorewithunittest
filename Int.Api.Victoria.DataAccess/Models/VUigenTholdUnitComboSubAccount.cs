using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class VUigenTholdUnitComboSubAccount
    {
        public long Idcustomer { get; set; }
        public long IdsubAccount { get; set; }
        public string SubAccountDisp { get; set; } = null!;
    }
}
