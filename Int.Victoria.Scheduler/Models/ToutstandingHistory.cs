using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class ToutstandingHistory
    {
        public string UnitHolderIdNo { get; set; } = null!;
        public string ProductCode { get; set; } = null!;
        public string SubIdTransaction { get; set; } = null!;
        public DateTime? SubNavdate { get; set; }
        public double? Units { get; set; }
        public string RedIdTransaction { get; set; } = null!;
        public DateTime? RedNavdate { get; set; }
    }
}
