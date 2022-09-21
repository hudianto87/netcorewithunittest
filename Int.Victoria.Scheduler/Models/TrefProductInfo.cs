using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TrefProductInfo
    {
        public int ProdInfoId { get; set; }
        public string? ProdInfoDesc { get; set; }
        public short? RecStatus { get; set; }
        public int? RecOrder { get; set; }
    }
}
