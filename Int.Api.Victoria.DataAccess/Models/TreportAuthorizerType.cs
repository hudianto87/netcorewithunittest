using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TreportAuthorizerType
    {
        public TreportAuthorizerType()
        {
            TreportAuthorizerDetails = new HashSet<TreportAuthorizerDetail>();
        }

        public long TreportAuthorizerTypeId { get; set; }
        public string AuthorizerType { get; set; } = null!;
        public string? Description { get; set; }

        public virtual ICollection<TreportAuthorizerDetail> TreportAuthorizerDetails { get; set; }
    }
}
