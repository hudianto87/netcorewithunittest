using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TftTargetParameter
    {
        public long TtargetParameterId { get; set; }
        public long TtargetId { get; set; }
        public int SeqNo { get; set; }
        public string ParameterName { get; set; } = null!;
        public int UserTypeId { get; set; }
        public int MaxLength { get; set; }
        public bool? IsNullable { get; set; }
        public bool? IsIdentity { get; set; }
        public bool? IsComputed { get; set; }
        public int CustomAuditType { get; set; }
        public string SysCreatedBy { get; set; } = null!;
        public DateTime SysCreatedTime { get; set; }
        public string SysCreatedHost { get; set; } = null!;
        public string? SysModifiedBy { get; set; }
        public DateTime? SysModifiedTime { get; set; }
        public string? SysModifiedHost { get; set; }

        public virtual TftTarget Ttarget { get; set; } = null!;
    }
}
