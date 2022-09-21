using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TfeeCustomer
    {
        public DateTime Navdate { get; set; }
        public string UnitholderIdNo { get; set; } = null!;
        public string ProductCode { get; set; } = null!;
        public DateTime? SaldoDate { get; set; }
        public string CodeBroker { get; set; } = null!;
        public string CodeAgent { get; set; } = null!;
        public double? SaldoUnits { get; set; }
        public double? TotalNetAsset { get; set; }
        public double? MfeeTotal { get; set; }
        public double? MfeeShare { get; set; }
        public double? MfeeOther { get; set; }
        public double? SfeeShare { get; set; }
        public double? FeeTxSubs { get; set; }
        public double? FeeTxRed { get; set; }
        public double? FeePpn { get; set; }
    }
}
