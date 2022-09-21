using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TlogEndOfDay
    {
        public DateTime Eoddate { get; set; }
        public DateTime? Navdate { get; set; }
        public string ProcessId { get; set; } = null!;
        public bool? IsProcessed { get; set; }
        public bool? IsSucceded { get; set; }
        public string? Desc { get; set; }
    }
}
