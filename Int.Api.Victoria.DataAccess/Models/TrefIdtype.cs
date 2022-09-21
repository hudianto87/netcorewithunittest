using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TrefIdtype
    {
        public string Idtype { get; set; } = null!;
        public string IdtypeDetail { get; set; } = null!;
        public string? Attribute1 { get; set; }
    }
}
