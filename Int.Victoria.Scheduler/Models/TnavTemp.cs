using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TnavTemp
    {
        public long Idnavtemp { get; set; }
        public long Idproduct { get; set; }
        public DateTime Navdate { get; set; }
        public double Value { get; set; }
        public double DividendRate { get; set; }
        public double TotalNetAsset { get; set; }
        public double OutstandingUnit { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime CreatedDate { get; set; }

        public virtual Tproduct IdproductNavigation { get; set; } = null!;
    }
}
