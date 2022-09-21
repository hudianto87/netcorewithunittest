using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TamlWatchlist
    {
        public long IdtamlWatchlist { get; set; }
        public string Category { get; set; } = null!;
        public string? NamaTamlWatchlist { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public string SysCreatedBy { get; set; } = null!;
        public DateTime SysCreatedTime { get; set; }
        public string SysCreatedHost { get; set; } = null!;
        public string? SysModifiedBy { get; set; }
        public DateTime? SysModifiedTime { get; set; }
        public string? SysModifiedHost { get; set; }
    }
}
