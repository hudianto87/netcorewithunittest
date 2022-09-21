using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TfeeAgentNew
    {
        public int? FeeDateInt { get; set; }
        public DateTime FeeDate { get; set; }
        public string ProductCode { get; set; } = null!;
        public string CodeAgent { get; set; } = null!;
        public double? UnitCustAum { get; set; }
        public double? UnitCustDisplay { get; set; }
        public double? NavperUnitAum { get; set; }
        public double? NavperUnitDisplay { get; set; }
        public double? Aum { get; set; }
        public double? Aumdisplay { get; set; }
        public double? MfeeTotal { get; set; }
        public double? MfeeShare { get; set; }
        public double? PenjualanRd { get; set; }
        public double? PembelianRd { get; set; }
    }
}
