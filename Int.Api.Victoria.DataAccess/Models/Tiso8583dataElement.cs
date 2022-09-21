using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class Tiso8583dataElement
    {
        public Tiso8583dataElement()
        {
            Tiso8583dataElementCategories = new HashSet<Tiso8583dataElementCategory>();
        }

        public long DataElementId { get; set; }
        public long MessageClassId { get; set; }
        public int Bit { get; set; }
        public string Name { get; set; } = null!;
        public string? Format { get; set; }
        public long DataTypeId { get; set; }
        public long LengthTypeId { get; set; }
        public int Length { get; set; }
        public bool IsAmount { get; set; }
        public bool IsGmt { get; set; }
        public string? Description { get; set; }
        public bool? IsFee { get; set; }

        public virtual Tiso8583dataType DataType { get; set; } = null!;
        public virtual Tiso8583lengthType LengthType { get; set; } = null!;
        public virtual Tiso8583messageClass MessageClass { get; set; } = null!;
        public virtual ICollection<Tiso8583dataElementCategory> Tiso8583dataElementCategories { get; set; }
    }
}
