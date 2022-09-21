using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TlinkTransaksi
    {
        public string Idtransaksi { get; set; } = null!;
        public string NoTransaksi { get; set; } = null!;
        public string TipeTransaksi { get; set; } = null!;
        public DateTime TglTransaksi { get; set; }
        public long Idcustomer { get; set; }
    }
}
