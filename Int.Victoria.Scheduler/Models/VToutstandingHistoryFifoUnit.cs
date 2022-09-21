using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class VToutstandingHistoryFifoUnit
    {
        public DateTime NavDate { get; set; }
        public string? UnitHolderIdno { get; set; }
        public string? ProductCode { get; set; }
        public double? NavValue { get; set; }
        public double Units { get; set; }
    }
}
