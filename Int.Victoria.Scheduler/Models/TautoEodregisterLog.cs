using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TautoEodregisterLog
    {
        public long TautoSubRegisterLogId { get; set; }
        public DateTime LogDate { get; set; }
        public string? Remarks { get; set; }
    }
}
