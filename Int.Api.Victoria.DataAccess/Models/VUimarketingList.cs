using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class VUimarketingList
    {
        public int AgentId { get; set; }
        public string? TreeCode2 { get; set; }
        public string? NameAgent { get; set; }
        public string? AgentLevelName { get; set; }
        public int? AgentLevelId { get; set; }
        public DateTime? EffDate { get; set; }
        public string? Idstatus { get; set; }
        public byte? SysApprovalStatus { get; set; }
        public string? SysActionType { get; set; }
    }
}
