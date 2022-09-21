using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class Tiso8583dataElementCategory
    {
        public Tiso8583dataElementCategory()
        {
            Tiso8583dataElementDetails = new HashSet<Tiso8583dataElementDetail>();
        }

        public long DataElementCategoryId { get; set; }
        public long DataElementId { get; set; }
        public string CategoryCode { get; set; } = null!;
        public string CategoryName { get; set; } = null!;

        public virtual Tiso8583dataElement DataElement { get; set; } = null!;
        public virtual ICollection<Tiso8583dataElementDetail> Tiso8583dataElementDetails { get; set; }
    }
}
