using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TbancAssuranceGenerateHistory
    {
        public long IdbancAssuranceGenerateHistory { get; set; }
        public string? FileName { get; set; }
        public int? NoUrut { get; set; }
        public string? Remarks { get; set; }
    }
}
