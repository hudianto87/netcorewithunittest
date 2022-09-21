using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class Tjob
    {
        public long TjobId { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public short TjobFrequencyId { get; set; }
        public short Interval { get; set; }
        public bool ExecuteOnHoliday { get; set; }
        public short TjobDailyFrequencyId { get; set; }
        public DateTime DailyTimeBegin { get; set; }
        public DateTime? DailyTimeEnd { get; set; }

        public virtual TjobDailyFrequency TjobDailyFrequency { get; set; } = null!;
        public virtual TjobFrequency TjobFrequency { get; set; } = null!;
    }
}
