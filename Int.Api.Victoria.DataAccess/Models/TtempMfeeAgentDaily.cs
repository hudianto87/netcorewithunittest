using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TtempMfeeAgentDaily
    {
        public string? AgentCode { get; set; }
        public string? ProductCode { get; set; }
        public DateTime? NavDate { get; set; }
        public double? Amount { get; set; }
        public double? Unit { get; set; }
    }
}
