using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class Tpph23
    {
        public string ProductCode { get; set; } = null!;
        public DateTime Date { get; set; }
        public double? Pph23 { get; set; }
    }
}
