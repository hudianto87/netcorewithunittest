using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TextMailTemplateParameter
    {
        public long MailTemplateParamId { get; set; }
        public long TextMailTemplateId { get; set; }
        public string? ParamName { get; set; }
        public string? ParamValue { get; set; }
        public string SysCreatedBy { get; set; } = null!;
        public DateTime SysCreatedTime { get; set; }
        public string SysCreatedHost { get; set; } = null!;
        public string? SysModifiedBy { get; set; }
        public DateTime? SysModifiedTime { get; set; }
        public string? SysModifiedHost { get; set; }
        public string? ParamTable { get; set; }

        public virtual TextMailTemplate TextMailTemplate { get; set; } = null!;
    }
}
