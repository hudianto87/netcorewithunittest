using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TtransactionLogCore
    {
        public long TtransactionLogCoreId { get; set; }
        public long Idtransaction { get; set; }
        public string ProcessingCode { get; set; } = null!;
        public string? RefNo { get; set; }
        public bool IsReverse { get; set; }
        public string? CustomerBankAccount { get; set; }
        public string? ProductBankAccount { get; set; }
        public string? GlbankAccount { get; set; }
        public string? FeeBankAccount { get; set; }
        public string? PpnBankAccount { get; set; }
        public double? NetAmount { get; set; }
        public double? FeeAmount { get; set; }
        public double? NetFeeAmount { get; set; }
        public double? Ppn { get; set; }
        public string? ResponseCode { get; set; }
        public string? ResponseDescription { get; set; }
        public string SysCreatedBy { get; set; } = null!;
        public DateTime SysCreatedTime { get; set; }
    }
}
