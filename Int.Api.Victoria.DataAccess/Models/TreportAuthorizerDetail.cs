using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TreportAuthorizerDetail
    {
        public long TreportAuthorizerDetailId { get; set; }
        public long TreportAuthorizerId { get; set; }
        public long TreportAuthorizerTypeId { get; set; }
        public long TauthorizerId { get; set; }
        public int Sequence { get; set; }
        public bool IsDefault { get; set; }
        public string SysCreatedBy { get; set; } = null!;
        public DateTime SysCreatedDate { get; set; }
        public string? SysModifiedBy { get; set; }
        public DateTime? SysModifiedDate { get; set; }

        public virtual Tauthorizer Tauthorizer { get; set; } = null!;
        public virtual TreportAuthorizer TreportAuthorizer { get; set; } = null!;
        public virtual TreportAuthorizerType TreportAuthorizerType { get; set; } = null!;
    }
}
