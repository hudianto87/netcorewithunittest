using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TproductBundling
    {
        public TproductBundling()
        {
            TproductBundlingDetails = new HashSet<TproductBundlingDetail>();
            TproductBundlingRegistrations = new HashSet<TproductBundlingRegistration>();
        }

        public long TproductBundlingId { get; set; }
        public string BundlingCode { get; set; } = null!;
        public string BundlingName { get; set; } = null!;
        public DateTime SysCreatedDate { get; set; }
        public string SysCreatedBy { get; set; } = null!;
        public DateTime? SysModifiedDate { get; set; }
        public string? SysModifiedBy { get; set; }

        public virtual ICollection<TproductBundlingDetail> TproductBundlingDetails { get; set; }
        public virtual ICollection<TproductBundlingRegistration> TproductBundlingRegistrations { get; set; }
    }
}
