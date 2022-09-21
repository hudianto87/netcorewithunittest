using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class Tprocess
    {
        public string ProcessId { get; set; } = null!;
        public string? ProcessName { get; set; }
        public string? SprocName { get; set; }
    }
}
