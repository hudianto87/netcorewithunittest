using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TrefDtspackage
    {
        public string Dtsname { get; set; } = null!;
        public string? Description { get; set; }
        public DateTime? LastRunTime { get; set; }
        public string? LastRunUser { get; set; }
    }
}
