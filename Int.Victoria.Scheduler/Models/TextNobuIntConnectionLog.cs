using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TextNobuIntConnectionLog
    {
        public long TextNobuIntConnectionLogId { get; set; }
        public DateTime Date { get; set; }
        public bool IsSuccess { get; set; }
        public bool IsClose { get; set; }
        public string? Remarks { get; set; }
    }
}
