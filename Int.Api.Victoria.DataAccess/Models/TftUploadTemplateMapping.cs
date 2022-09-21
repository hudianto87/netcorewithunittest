using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TftUploadTemplateMapping
    {
        public long TuploadTemplateMappingId { get; set; }
        public long TuploadId { get; set; }
        public string TemplateColumnName { get; set; } = null!;
        public string TargetParameterName { get; set; } = null!;
        public bool? IsUpdateChecking { get; set; }
        public int MappingType { get; set; }
        public bool? IsValueNull { get; set; }
        public string SysCreatedBy { get; set; } = null!;
        public DateTime SysCreatedTime { get; set; }
        public string SysCreatedHost { get; set; } = null!;
        public string? SysModifiedBy { get; set; }
        public DateTime? SysModifiedTime { get; set; }
        public string? SysModifiedHost { get; set; }

        public virtual TftUpload Tupload { get; set; } = null!;
    }
}
