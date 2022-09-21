using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TextHighNetworkCustomer
    {
        public long TextHighNetworkCustomerId { get; set; }
        public long TextHighNetworkId { get; set; }
        public long Idcustomer { get; set; }
        public double TotalAum { get; set; }
        public bool? IsActive { get; set; }
        public string? Remarks { get; set; }
        public string SysCreatedBy { get; set; } = null!;
        public DateTime SysCreatedTime { get; set; }
        public string SysCreatedHost { get; set; } = null!;
        public string? SysModifiedBy { get; set; }
        public DateTime? SysModifiedTime { get; set; }
        public string? SysModifiedHost { get; set; }

        public virtual Tcustomer IdcustomerNavigation { get; set; } = null!;
        public virtual TextHighNetwork TextHighNetwork { get; set; } = null!;
    }
}
