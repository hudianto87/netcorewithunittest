using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class Tiso8583dataElementDetail
    {
        public long DataElementDetailId { get; set; }
        public long DataElementCategoryId { get; set; }
        public int Sequence { get; set; }
        public string Name { get; set; } = null!;
        public string? Format { get; set; }
        public long LengthTypeId { get; set; }
        public int Length { get; set; }
        public string? Description { get; set; }

        public virtual Tiso8583dataElementCategory DataElementCategory { get; set; } = null!;
    }
}
