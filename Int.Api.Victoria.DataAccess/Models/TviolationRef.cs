using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TviolationRef
    {
        public int TviolationRefId { get; set; }
        public string ViolationRefName { get; set; } = null!;
    }
}
