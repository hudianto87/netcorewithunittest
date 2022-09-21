using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TextBtpnRtgssettlementLog
    {
        public long TextBtpnRtgssettlementLogId { get; set; }
        public long TextBtpnRtgssettlementId { get; set; }
        public string ProcessingCode { get; set; } = null!;
        public string? RefNo { get; set; }
        public string? ProductBankAccount { get; set; }
        public string? KseibankAccount { get; set; }
        public double Amount { get; set; }
        public string? ResponseCode { get; set; }
        public string? ResponseDesc { get; set; }
        public string? PaymentRefrence { get; set; }
        public string SysCreatedBy { get; set; } = null!;
        public DateTime SysCreatedTime { get; set; }
        public string? SysCreatedHost { get; set; }
    }
}
