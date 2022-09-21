using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TjobDailyFrequency
    {
        public TjobDailyFrequency()
        {
            Tjobs = new HashSet<Tjob>();
        }

        public short TjobDailyFrequencyId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Tjob> Tjobs { get; set; }
    }
}
