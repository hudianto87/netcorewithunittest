using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TextMailTemplateAttachment
    {
        public long TextMailTemplateAttachmentId { get; set; }
        public long TextMailTemplateId { get; set; }
        public int AttachmentType { get; set; }
        public string? AttachmentValue { get; set; }
        public string? Rdlparameters { get; set; }
        public string SysCreatedBy { get; set; } = null!;
        public DateTime SysCreatedTime { get; set; }
        public string SysCreatedHost { get; set; } = null!;
        public string? SysModifiedBy { get; set; }
        public DateTime? SysModifiedTime { get; set; }
        public string? SysModifiedHost { get; set; }
        public string? FileName { get; set; }
        public string? FileFormat { get; set; }
        public string? FromDbfileName { get; set; }

        public virtual TextMailTemplate TextMailTemplate { get; set; } = null!;
    }
}
