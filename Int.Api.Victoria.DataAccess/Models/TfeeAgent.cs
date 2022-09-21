using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TfeeAgent
    {
        public string CodeAgent { get; set; } = null!;
        public string ProductCode { get; set; } = null!;
        public DateTime Navdate { get; set; }
        public DateTime? SaldoDate { get; set; }
        public double? SaldoUnit { get; set; }
        public double? TotalNetAsset { get; set; }
        public double? TotalNetAsset1 { get; set; }
        public double? MfeeTotal { get; set; }
        public double? MfeeTotal1 { get; set; }
        public double? MfeeShare { get; set; }
        public double? MfeeOther { get; set; }
        public double? Mfeeshareadj { get; set; }
        public double? Mfeeotheradj { get; set; }
        public double? SfeeShare { get; set; }
        public double? FeeTxSubs { get; set; }
        public double? FeeTxRed { get; set; }
        public double? FeePpn { get; set; }
        public double? TotalFundIdr { get; set; }
    }
}
