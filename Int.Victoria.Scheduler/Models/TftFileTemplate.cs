using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TftFileTemplate
    {
        public TftFileTemplate()
        {
            TftFileTemplateColumns = new HashSet<TftFileTemplateColumn>();
            TftFileTemplateSamples = new HashSet<TftFileTemplateSample>();
            TftUploads = new HashSet<TftUpload>();
        }

        public long TfileTemplateId { get; set; }
        public string TemplateName { get; set; } = null!;
        public int TrefFileFormatId { get; set; }
        public bool HasHeader { get; set; }
        public bool? ReadHeader { get; set; }
        public string? Delimiter { get; set; }
        public string? TextQualifier { get; set; }
        public string? AllowedFileExtensions { get; set; }
        public string? SheetName { get; set; }
        public string? Remarks { get; set; }
        public string SysCreatedBy { get; set; } = null!;
        public DateTime SysCreatedTime { get; set; }
        public string SysCreatedHost { get; set; } = null!;
        public string? SysModifiedBy { get; set; }
        public DateTime? SysModifiedTime { get; set; }
        public string? SysModifiedHost { get; set; }

        public virtual ICollection<TftFileTemplateColumn> TftFileTemplateColumns { get; set; }
        public virtual ICollection<TftFileTemplateSample> TftFileTemplateSamples { get; set; }
        public virtual ICollection<TftUpload> TftUploads { get; set; }
    }
}
