using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TmarketingHistory
    {
        public long IdAgentHistory { get; set; }
        public int? IdAgent { get; set; }
        public int? ParentId { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual Tagent? Parent { get; set; }
    }
}
