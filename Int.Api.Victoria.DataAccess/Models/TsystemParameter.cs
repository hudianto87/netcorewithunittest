using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TsystemParameter
    {
        public string ParamKey { get; set; } = null!;
        public string? ParamValue { get; set; }
        public string? ParamType { get; set; }
        public string? ParamDesc { get; set; }
        public string? DefaultValue { get; set; }
        public byte? RecStatus { get; set; }
        public int? RecOrder { get; set; }
    }
}
