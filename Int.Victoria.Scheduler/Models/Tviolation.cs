using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class Tviolation
    {
        public Tviolation()
        {
            TviolationMappings = new HashSet<TviolationMapping>();
        }

        public int ViolationId { get; set; }
        public string ViolationNo { get; set; } = null!;
        public string? ViolationGroup { get; set; }
        public string? ViolationDescription { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<TviolationMapping> TviolationMappings { get; set; }
    }
}
