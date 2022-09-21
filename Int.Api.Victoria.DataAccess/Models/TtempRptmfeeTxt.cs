using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TtempRptmfeeTxt
    {
        public string Idtrans { get; set; } = null!;
        public string Productcode { get; set; } = null!;
        public string Codeagent { get; set; } = null!;
        public double? Amount { get; set; }
    }
}
