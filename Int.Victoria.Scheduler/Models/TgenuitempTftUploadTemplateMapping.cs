using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TgenuitempTftUploadTemplateMapping
    {
        public long TgenuitempTableId { get; set; }
        public string TgenuitempSessionId { get; set; } = null!;
        public long? TgenuitempIdmaster { get; set; }
        public long? TgenuitempIddetail { get; set; }
        public short TgenuitempChangeFlag { get; set; }
        public string TgenuitempSysCreatedBy { get; set; } = null!;
        public DateTime TgenuitempSysCreatedTime { get; set; }
        public string TgenuitempSysCreatedHost { get; set; } = null!;
        public string? TgenuitempSysModifiedBy { get; set; }
        public DateTime? TgenuitempSysModifiedTime { get; set; }
        public string? TgenuitempSysModifiedHost { get; set; }
        public long? TuploadTemplateMappingId { get; set; }
        public long? TuploadId { get; set; }
        public string? TemplateColumnName { get; set; }
        public string? TargetParameterName { get; set; }
        public bool? IsUpdateChecking { get; set; }
        public int? MappingType { get; set; }
        public bool? IsValueNull { get; set; }
        public string? SysCreatedBy { get; set; }
        public DateTime? SysCreatedTime { get; set; }
        public string? SysCreatedHost { get; set; }
        public string? SysModifiedBy { get; set; }
        public DateTime? SysModifiedTime { get; set; }
        public string? SysModifiedHost { get; set; }
    }
}
