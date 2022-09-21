using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TftTarget
    {
        public TftTarget()
        {
            TftTargetParameters = new HashSet<TftTargetParameter>();
            TftUploads = new HashSet<TftUpload>();
        }

        public long TtargetId { get; set; }
        public int TargetDbno { get; set; }
        public int TargetType { get; set; }
        public string TargetName { get; set; } = null!;
        public string ObjectName { get; set; } = null!;
        public string? IdcolumnName { get; set; }
        public bool? AllowUpdate { get; set; }
        public int ColumnAuditType { get; set; }
        public string? Remarks { get; set; }
        public string SysCreatedBy { get; set; } = null!;
        public DateTime SysCreatedTime { get; set; }
        public string SysCreatedHost { get; set; } = null!;
        public string? SysModifiedBy { get; set; }
        public DateTime? SysModifiedTime { get; set; }
        public string? SysModifiedHost { get; set; }

        public virtual TftDb TargetDbnoNavigation { get; set; } = null!;
        public virtual ICollection<TftTargetParameter> TftTargetParameters { get; set; }
        public virtual ICollection<TftUpload> TftUploads { get; set; }
    }
}
