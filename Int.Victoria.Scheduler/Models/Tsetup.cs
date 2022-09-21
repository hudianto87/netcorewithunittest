using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class Tsetup
    {
        public string KdFile { get; set; } = null!;
        public double? SeqId { get; set; }
        public string? FileCode { get; set; }
        public string? FieldCode { get; set; }
        public string? IsActive { get; set; }
        public double? SeqIdtext { get; set; }
    }
}
