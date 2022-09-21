using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TmappingConversiFw
    {
        public string Fwprefix { get; set; } = null!;
        public string TableName { get; set; } = null!;
        public string FieldName { get; set; } = null!;
        public string Fwconversion { get; set; } = null!;
        public string ConversionCode { get; set; } = null!;
        public string? FwPrefix1 { get; set; }
        public DateTime? FwTimeStamp { get; set; }
    }
}
