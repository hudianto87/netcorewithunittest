using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class VUigenTholdUnitComboOldHoldUnit
    {
        public long TholdUnitId { get; set; }
        public long Idcustomer { get; set; }
        public long? IdsubAccount { get; set; }
        public string? OldHoldUnitDisp { get; set; }
    }
}
