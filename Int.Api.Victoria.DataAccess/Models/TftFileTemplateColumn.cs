using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TftFileTemplateColumn
    {
        public long TfileTemplateColumnId { get; set; }
        public long TfileTemplateId { get; set; }
        public int SeqNo { get; set; }
        public string ColumnName { get; set; } = null!;
        public int TrefColumnDataTypeId { get; set; }
        public bool ShowInPreview { get; set; }
        public string? DefaultValue { get; set; }
        public int ErrorHandlingOnBlankInput { get; set; }
        public string? Format { get; set; }
        public string? Culture { get; set; }
        public long? TtransLookupId { get; set; }
        public string SysCreatedBy { get; set; } = null!;
        public DateTime SysCreatedTime { get; set; }
        public string SysCreatedHost { get; set; } = null!;
        public string? SysModifiedBy { get; set; }
        public DateTime? SysModifiedTime { get; set; }
        public string? SysModifiedHost { get; set; }
        public string? StrRegexValidation1 { get; set; }
        public bool? StrRegexValidation1IgnoreCase { get; set; }
        public int? StrRegexValidation1ErrHandling { get; set; }
        public string? StrRegexValidation1ErrMsg { get; set; }

        public virtual TftFileTemplate TfileTemplate { get; set; } = null!;
        public virtual TftTransLookup? TtransLookup { get; set; }
    }
}
