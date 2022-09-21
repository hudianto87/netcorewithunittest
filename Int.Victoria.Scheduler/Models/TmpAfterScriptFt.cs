using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TmpAfterScriptFt
    {
        public long TblId { get; set; }
        public long KeyField { get; set; }
        public string? UserName { get; set; }
        public string? Host { get; set; }
        public DateTime? CurrTime { get; set; }
        public string? H2href { get; set; }
        public string? Token { get; set; }
        public string? Data1 { get; set; }
    }
}
