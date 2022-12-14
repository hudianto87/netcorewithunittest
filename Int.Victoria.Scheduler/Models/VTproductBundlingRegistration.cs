using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class VTproductBundlingRegistration
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
        public string? FullName { get; set; }
    }
}
