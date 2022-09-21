using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TproductBundlingRegistration
    {
        public long TproductBundlingRegistrationId { get; set; }
        public long Idcustomer { get; set; }
        public long TproductBundlingId { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public string? AccountNo { get; set; }
        public double Amount { get; set; }
        public DateTime SysCreatedDate { get; set; }
        public string SysCreatedBy { get; set; } = null!;
        public DateTime? SysModifiedDate { get; set; }
        public string? SysModifiedBy { get; set; }

        public virtual Tcustomer IdcustomerNavigation { get; set; } = null!;
        public virtual TproductBundling TproductBundling { get; set; } = null!;
    }
}
