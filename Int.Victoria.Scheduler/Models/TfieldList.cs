using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TfieldList
    {
        public long FieldId { get; set; }
        public int TableId { get; set; }
        public string? FieldName { get; set; }
        public string? FieldAlias { get; set; }
        public string? FieldAliasAlt { get; set; }
        public string? ControlName { get; set; }
        public string? FormName { get; set; }
        public bool? MandatoryFlag { get; set; }
        public string? MandatoryMark { get; set; }
        public string? EmptyMessage { get; set; }
        public string? EmptyMessageAlt { get; set; }
        public string? FieldDescription { get; set; }
        public bool? FieldVisible { get; set; }
        public string? RecAttribute1 { get; set; }
        public string? RecAttribute2 { get; set; }
        public string? RecAttribute3 { get; set; }
        public int? RecOrder { get; set; }
        public byte? RecStatus { get; set; }
        public DateTime? RecCreatedDate { get; set; }
        public string? RecCreatedBy { get; set; }
        public DateTime? RecModifiedDate { get; set; }
        public string? RecModifiedBy { get; set; }

        public virtual TtableList Table { get; set; } = null!;
    }
}
