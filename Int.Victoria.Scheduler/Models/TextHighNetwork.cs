using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TextHighNetwork
    {
        public TextHighNetwork()
        {
            TextHighNetworkCustomers = new HashSet<TextHighNetworkCustomer>();
        }

        public long TextHighNetworkId { get; set; }
        public DateTime EffectiveDate { get; set; }
        public DateTime Aumdate { get; set; }
        public bool? IsActive { get; set; }
        public string? Remarks { get; set; }
        public string SysCreatedBy { get; set; } = null!;
        public DateTime SysCreatedTime { get; set; }
        public string SysCreatedHost { get; set; } = null!;
        public string? SysModifiedBy { get; set; }
        public DateTime? SysModifiedTime { get; set; }
        public string? SysModifiedHost { get; set; }

        public virtual ICollection<TextHighNetworkCustomer> TextHighNetworkCustomers { get; set; }
    }
}
