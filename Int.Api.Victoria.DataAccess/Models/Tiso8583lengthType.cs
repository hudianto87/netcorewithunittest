using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class Tiso8583lengthType
    {
        public Tiso8583lengthType()
        {
            Tiso8583dataElements = new HashSet<Tiso8583dataElement>();
        }

        public long LengthTypeId { get; set; }
        public string Notation { get; set; } = null!;
        public string? Description { get; set; }

        public virtual ICollection<Tiso8583dataElement> Tiso8583dataElements { get; set; }
    }
}
