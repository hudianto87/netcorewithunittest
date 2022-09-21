using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class Tiso8583messageClass
    {
        public Tiso8583messageClass()
        {
            Tiso8583dataElements = new HashSet<Tiso8583dataElement>();
        }

        public long MessageClassId { get; set; }
        public string ClassCode { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? Description { get; set; }

        public virtual ICollection<Tiso8583dataElement> Tiso8583dataElements { get; set; }
    }
}
