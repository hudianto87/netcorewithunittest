using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TjournalPrm
    {
        public string? TransId { get; set; }
        public string? Ccy { get; set; }
        public string? TransName { get; set; }
        public string? Treference { get; set; }
        public string? JrnalType { get; set; }
        public string? Descr { get; set; }
        public string? AnalT0 { get; set; }
        public string? AnalT1 { get; set; }
    }
}
