using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TreportAuthorizer
    {
        public TreportAuthorizer()
        {
            TreportAuthorizerDetails = new HashSet<TreportAuthorizerDetail>();
        }

        public long TreportAuthorizerId { get; set; }
        public string ReportId { get; set; } = null!;
        public string? Remarks { get; set; }
        public string SysCreatedBy { get; set; } = null!;
        public DateTime SysCreatedDate { get; set; }
        public string? SysModifiedBy { get; set; }
        public DateTime? SysModifiedDate { get; set; }

        public virtual ICollection<TreportAuthorizerDetail> TreportAuthorizerDetails { get; set; }
    }
}
