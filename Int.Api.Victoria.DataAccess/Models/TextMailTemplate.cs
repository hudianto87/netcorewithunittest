using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TextMailTemplate
    {
        public TextMailTemplate()
        {
            TextMailTemplateAttachments = new HashSet<TextMailTemplateAttachment>();
            TextMailTemplateParameters = new HashSet<TextMailTemplateParameter>();
        }

        public long TextMailTemplateId { get; set; }
        public string TemplateKey { get; set; } = null!;
        public string Subject { get; set; } = null!;
        public string Header { get; set; } = null!;
        public string Body { get; set; } = null!;
        public string? Footer { get; set; }
        public bool? IsActive { get; set; }
        public string? Remarks { get; set; }
        public string SysCreatedBy { get; set; } = null!;
        public DateTime SysCreatedTime { get; set; }
        public string SysCreatedHost { get; set; } = null!;
        public string? SysModifiedBy { get; set; }
        public DateTime? SysModifiedTime { get; set; }
        public string? SysModifiedHost { get; set; }
        public string? SysDeletedBy { get; set; }
        public DateTime? SysDeletedTime { get; set; }
        public string? SysDeletedHost { get; set; }
        public string? HeaderEng { get; set; }
        public string? BodyEng { get; set; }
        public string? FooterEng { get; set; }
        public long TsendMailAccountId { get; set; }

        public virtual ICollection<TextMailTemplateAttachment> TextMailTemplateAttachments { get; set; }
        public virtual ICollection<TextMailTemplateParameter> TextMailTemplateParameters { get; set; }
    }
}
