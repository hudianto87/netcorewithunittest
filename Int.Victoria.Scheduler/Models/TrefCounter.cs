using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TrefCounter
    {
        public long TrefCounterId { get; set; }
        public string Category { get; set; } = null!;
        public long LastCounter { get; set; }
        public DateTime SysCreatedTime { get; set; }
    }
}
