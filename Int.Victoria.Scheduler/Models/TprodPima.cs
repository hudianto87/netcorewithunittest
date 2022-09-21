using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TprodPima
    {
        public int Pimaid { get; set; }
        public int? ProductId { get; set; }
        public string? DocTitle { get; set; }
        public string? DocLocation { get; set; }
        public DateTime? DocDate { get; set; }
        public string? Contents { get; set; }
    }
}
