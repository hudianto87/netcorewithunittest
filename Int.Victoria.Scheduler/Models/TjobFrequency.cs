using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TjobFrequency
    {
        public TjobFrequency()
        {
            Tjobs = new HashSet<Tjob>();
        }

        public short TjobFrequencyId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Tjob> Tjobs { get; set; }
    }
}
