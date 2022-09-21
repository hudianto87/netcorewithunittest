using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class EmailParameter
    {
        public string ParamKey { get; set; } = null!;
        public string ParamValue { get; set; } = null!;
        public string? ParamDesc { get; set; }
        public string? ParamDataType { get; set; }
    }
}
