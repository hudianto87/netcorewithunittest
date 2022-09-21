using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TtableList
    {
        public TtableList()
        {
            TfieldLists = new HashSet<TfieldList>();
        }

        public int TableId { get; set; }
        public int? ParentId { get; set; }
        public int? ModuleId { get; set; }
        public string TableName { get; set; } = null!;
        public string? TableTitle { get; set; }
        public string? TableDescription { get; set; }
        public string? RecAttribute1 { get; set; }
        public string? RecAttribute2 { get; set; }
        public string? RecAttribute3 { get; set; }
        public int? RecType { get; set; }
        public int? RecOrder { get; set; }
        public byte? RecStatus { get; set; }
        public DateTime? RecCreatedDate { get; set; }
        public string? RecCreatedBy { get; set; }
        public DateTime? RecModifiedDate { get; set; }
        public string? RecModifiedBy { get; set; }

        public virtual Tmodule? Module { get; set; }
        public virtual ICollection<TfieldList> TfieldLists { get; set; }
    }
}
