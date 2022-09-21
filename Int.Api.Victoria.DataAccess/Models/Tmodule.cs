using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class Tmodule
    {
        public Tmodule()
        {
            TtableLists = new HashSet<TtableList>();
        }

        public int ModuleId { get; set; }
        public int? ParentId { get; set; }
        public string? ModuleCode { get; set; }
        public string? ModuleName { get; set; }
        public string? ModuleDescription { get; set; }
        public int? RecType { get; set; }
        public int? RecOrder { get; set; }
        public bool? RecEnabled { get; set; }
        public byte? RecStatus { get; set; }
        public DateTime? RecCreatedDate { get; set; }
        public string? RecCreatedBy { get; set; }
        public DateTime? RecModifiedDate { get; set; }
        public string? RecModifiedBy { get; set; }

        public virtual ICollection<TtableList> TtableLists { get; set; }
    }
}
