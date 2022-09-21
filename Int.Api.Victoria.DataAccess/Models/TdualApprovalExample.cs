using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TdualApprovalExample
    {
        public long TdualApprovalExampleId { get; set; }
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public int? Value1 { get; set; }
        public double? Value2 { get; set; }
        public bool IsActive { get; set; }
        public string? Remarks { get; set; }
        public string SysCreatedBy { get; set; } = null!;
        public DateTime SysCreatedTime { get; set; }
        public string SysCreatedHost { get; set; } = null!;
        public string? SysModifiedBy { get; set; }
        public DateTime? SysModifiedTime { get; set; }
        public string? SysModifiedHost { get; set; }
    }
}
