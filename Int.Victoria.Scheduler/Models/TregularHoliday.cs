using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TregularHoliday
    {
        public long TregularHolidayId { get; set; }
        public int RegNo { get; set; }
        public string Name { get; set; } = null!;
        public long TexchangeId { get; set; }
        public string SysCreatedBy { get; set; } = null!;
        public DateTime SysCreatedDate { get; set; }
        public string? SysModifiedBy { get; set; }
        public DateTime? SysModifiedDate { get; set; }
    }
}
