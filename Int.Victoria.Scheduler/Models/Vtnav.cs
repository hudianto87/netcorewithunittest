using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class Vtnav
    {
        public string FundHouseName { get; set; } = null!;
        public string? CustodyName { get; set; }
        public string CurrencyNav { get; set; } = null!;
        public string ProductCode { get; set; } = null!;
        public DateTime? Navdate { get; set; }
        public double? Value { get; set; }
        public double? OutstandingUnit { get; set; }
        public double? TotalNetAsset { get; set; }
        public double? DividendRate { get; set; }
        public byte? SysApprovalStatus { get; set; }
        public string? SysActionType { get; set; }
        public long? Idproduct { get; set; }
        public long Idnav { get; set; }
    }
}
