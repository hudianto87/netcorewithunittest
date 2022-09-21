using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TftDb
    {
        public TftDb()
        {
            TftTargets = new HashSet<TftTarget>();
            TftTransLookups = new HashSet<TftTransLookup>();
        }

        public long Tdbid { get; set; }
        public int Dbno { get; set; }
        public string Name { get; set; } = null!;
        public string ConnectionString { get; set; } = null!;
        public string? Remarks { get; set; }
        public string SysCreatedBy { get; set; } = null!;
        public DateTime SysCreatedTime { get; set; }
        public string SysCreatedHost { get; set; } = null!;
        public string? SysModifiedBy { get; set; }
        public DateTime? SysModifiedTime { get; set; }
        public string? SysModifiedHost { get; set; }

        public virtual ICollection<TftTarget> TftTargets { get; set; }
        public virtual ICollection<TftTransLookup> TftTransLookups { get; set; }
    }
}
