using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TextCimbCustomerRegInvPlanLog
    {
        public long IdtextCimbCustomerRegInvPlanLog { get; set; }
        public long? TcustomerRegInvestmentPlanId { get; set; }
        public long? Idtransaction { get; set; }
        public DateTime? GeneratedDate { get; set; }
        public int? ErrorStatus { get; set; }
        public string? ErrorMessage { get; set; }
        public string? SysCreatedBy { get; set; }
        public DateTime? SysCreatedDate { get; set; }
        public string? SysCreatedHost { get; set; }
    }
}
