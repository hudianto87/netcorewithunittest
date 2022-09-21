using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TauditTrailLookupMapping
    {
        public long TauditTrailLookupMappingId { get; set; }
        public string TabelName { get; set; } = null!;
        public string ColumnName { get; set; } = null!;
        public string LookupTableName { get; set; } = null!;
        public string LookupTabelColumnValue { get; set; } = null!;
        public string LookupTabelColumnText { get; set; } = null!;
        public string? Description { get; set; }
        public DateTime SysCreatedDate { get; set; }
        public string SysCreatedBy { get; set; } = null!;
        public DateTime? SysModifiedDate { get; set; }
        public string? SysModifiedBy { get; set; }
    }
}
