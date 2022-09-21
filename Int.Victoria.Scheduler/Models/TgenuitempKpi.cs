using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TgenuitempKpi
    {
        public long TgenuitempTableId { get; set; }
        public string TgenuitempSessionId { get; set; } = null!;
        public long? TgenuitempIdmaster { get; set; }
        public long? TgenuitempIddetail { get; set; }
        public short TgenuitempChangeFlag { get; set; }
        public string TgenuitempSysCreatedBy { get; set; } = null!;
        public DateTime TgenuitempSysCreatedTime { get; set; }
        public string? TgenuitempSysCreatedHost { get; set; }
        public string? TgenuitempSysModifiedBy { get; set; }
        public string? TgenuitempSysModifiedTime { get; set; }
        public string? TgenuitempSysModifiedHost { get; set; }
        public long? Idkpi { get; set; }
        public double? Ncf { get; set; }
        public double? Revenue { get; set; }
        public string? NumberOfActiveAccount { get; set; }
        public string? ShareOfWallet { get; set; }
        public double? ComplianceAndSalesDevelopment { get; set; }
    }
}
