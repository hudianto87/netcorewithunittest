using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class Tauthorizer
    {
        public Tauthorizer()
        {
            TreportAuthorizerDetails = new HashSet<TreportAuthorizerDetail>();
        }

        public long TauthorizerId { get; set; }
        public string Name { get; set; } = null!;
        public string Position { get; set; } = null!;
        public string? Remarks { get; set; }
        public string SysCreatedBy { get; set; } = null!;
        public DateTime SysCreatedDate { get; set; }
        public string? SysModifiedBy { get; set; }
        public DateTime? SysModifiedDate { get; set; }

        public virtual ICollection<TreportAuthorizerDetail> TreportAuthorizerDetails { get; set; }
    }
}
