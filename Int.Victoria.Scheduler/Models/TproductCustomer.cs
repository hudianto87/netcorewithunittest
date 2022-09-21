using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TproductCustomer
    {
        public long TproductCustomerId { get; set; }
        public long Idproduct { get; set; }
        public long LastNo { get; set; }
        public string SysCreatedBy { get; set; } = null!;
        public DateTime SysCreatedDate { get; set; }
        public string? SysModifiedBy { get; set; }
        public DateTime? SysModifiedDate { get; set; }

        public virtual Tproduct IdproductNavigation { get; set; } = null!;
    }
}
