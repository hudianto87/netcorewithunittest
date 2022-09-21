using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class VTrefKotaNew
    {
        public string Kode { get; set; } = null!;
        public string Propinsi { get; set; } = null!;
        public string Kabupaten { get; set; } = null!;
        public string Kecamatan { get; set; } = null!;
        public string Kelurahan { get; set; } = null!;
        public string? KodePos { get; set; }
    }
}
