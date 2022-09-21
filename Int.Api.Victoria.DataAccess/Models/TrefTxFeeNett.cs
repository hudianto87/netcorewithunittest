using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TrefTxFeeNett
    {
        public string IdtxFeeNett { get; set; } = null!;
        public string TxFeeNett { get; set; } = null!;
        public string? TypeTxFeeNett { get; set; }
    }
}
