using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TextBtpnRtgssettlement
    {
        public TextBtpnRtgssettlement()
        {
            TextBtpnRtgssettlementTransactions = new HashSet<TextBtpnRtgssettlementTransaction>();
        }

        public long TextBtpnRtgssettlementId { get; set; }
        public long Idproduct { get; set; }
        public DateTime Date { get; set; }
        public string ProductBankAccount { get; set; } = null!;
        public string KseibankAccount { get; set; } = null!;
        public double Amount { get; set; }
        public int TextBtpnRtgssettlementStatusId { get; set; }
        public string SysCreatedBy { get; set; } = null!;
        public DateTime SysCreatedTime { get; set; }
        public string SysCreatedHost { get; set; } = null!;
        public string? SysModifiedBy { get; set; }
        public DateTime? SysModifiedTime { get; set; }
        public string? SysModifiedHost { get; set; }
        public string? SysPendingBy { get; set; }
        public DateTime? SysPendingTime { get; set; }
        public string? SysPendingHost { get; set; }
        public string? SysApprovedBy { get; set; }
        public DateTime? SysApprovedTime { get; set; }
        public string? SysApprovedHost { get; set; }

        public virtual TextBtpnRtgssettlementStatus TextBtpnRtgssettlementStatus { get; set; } = null!;
        public virtual ICollection<TextBtpnRtgssettlementTransaction> TextBtpnRtgssettlementTransactions { get; set; }
    }
}
