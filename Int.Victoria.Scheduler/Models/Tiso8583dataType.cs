using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class Tiso8583dataType
    {
        public Tiso8583dataType()
        {
            Tiso8583dataElements = new HashSet<Tiso8583dataElement>();
        }

        public long DataTypeId { get; set; }
        public string Notation { get; set; } = null!;
        public string? Description { get; set; }

        public virtual ICollection<Tiso8583dataElement> Tiso8583dataElements { get; set; }
    }
}
