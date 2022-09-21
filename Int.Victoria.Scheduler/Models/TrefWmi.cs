using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TrefWmi
    {
        public int Idwmi { get; set; }
        public string? Nama { get; set; }
        public string? NomorSk { get; set; }
        public DateTime? TanggalSk { get; set; }
        public int? Idjabatan { get; set; }
        public DateTime? TanggalMulaiBekerja { get; set; }
        public string? Rating { get; set; }
    }
}
