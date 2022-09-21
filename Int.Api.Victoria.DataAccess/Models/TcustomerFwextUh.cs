using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TcustomerFwextUh
    {
        public string UnitHolderIdno { get; set; } = null!;
        public string FwPrefix { get; set; } = null!;
        public string? ExternalUnitHolder { get; set; }
    }
}
