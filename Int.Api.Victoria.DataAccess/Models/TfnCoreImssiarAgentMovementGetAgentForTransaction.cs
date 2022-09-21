using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TfnCoreImssiarAgentMovementGetAgentForTransaction
    {
        public string? TreeCode2 { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public long? SalesAgentId { get; set; }
        public string? SalesCodeAgent { get; set; }
        public string? SalesNameAgent { get; set; }
        public int? SalesLevelId { get; set; }
        public string? SalesTreeCode2 { get; set; }
        public long? TeamLeaderAgentId { get; set; }
        public string? TeamLeaderCodeAgent { get; set; }
        public string? TeamLeaderNameAgent { get; set; }
        public int? TeamLeaderLevelId { get; set; }
        public string? TeamLeaderTreeCode2 { get; set; }
        public long? BranchAgentId { get; set; }
        public string? BranchCodeAgent { get; set; }
        public string? BranchNameAgent { get; set; }
        public int? BranchLevelId { get; set; }
        public string? BranchTreeCode2 { get; set; }
    }
}
