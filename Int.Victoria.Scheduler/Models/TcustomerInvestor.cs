using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TcustomerInvestor
    {
        public long Idproduct { get; set; }
        public string? Cifno { get; set; }
        public string? CustomerNameTrim { get; set; }
        public int IdbankCustody { get; set; }
        public long? Idcustomer { get; set; }
    }
}
