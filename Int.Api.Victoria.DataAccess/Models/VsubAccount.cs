using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class VsubAccount
    {
        public long IdsubAccount { get; set; }
        public string UnitHolderIdno { get; set; } = null!;
        public string ProductCode { get; set; } = null!;
        public string? FullName { get; set; }
        public string ProductName { get; set; } = null!;
        public string NoAccount { get; set; } = null!;
        public int? AgentId { get; set; }
        public string? AgentTreeCode { get; set; }
        public string? NameAgent { get; set; }
    }
}
