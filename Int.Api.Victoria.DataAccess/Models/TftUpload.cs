using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TftUpload
    {
        public TftUpload()
        {
            TftUploadTemplateMappings = new HashSet<TftUploadTemplateMapping>();
        }

        public long TuploadId { get; set; }
        public string UploadName { get; set; } = null!;
        public long TfileTemplateId { get; set; }
        public long TtargetId { get; set; }
        public bool AtomicUpload { get; set; }
        public bool AllowUploadOnFailedRow { get; set; }
        public bool ShowCheckbox { get; set; }
        public bool DefaultCheckboxState { get; set; }
        public string? Remarks { get; set; }
        public string SysCreatedBy { get; set; } = null!;
        public DateTime SysCreatedTime { get; set; }
        public string SysCreatedHost { get; set; } = null!;
        public string? SysModifiedBy { get; set; }
        public DateTime? SysModifiedTime { get; set; }
        public string? SysModifiedHost { get; set; }

        public virtual TftFileTemplate TfileTemplate { get; set; } = null!;
        public virtual TftTarget Ttarget { get; set; } = null!;
        public virtual ICollection<TftUploadTemplateMapping> TftUploadTemplateMappings { get; set; }
    }
}
