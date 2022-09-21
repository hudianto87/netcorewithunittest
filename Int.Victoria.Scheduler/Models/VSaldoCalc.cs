using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class VSaldoCalc
    {
        public string? UnitHolderIdno { get; set; }
        public string? ProductCode { get; set; }
        public DateTime? Navdate { get; set; }
        public double? Navvalue { get; set; }
        public string? CodeAgent { get; set; }
        public int CodeBroker { get; set; }
        public long? IdsubAccount { get; set; }
        public double Subunits { get; set; }
        public double Subamount { get; set; }
        public double Redunits { get; set; }
        public double Redamount { get; set; }
        public double Swtinunits { get; set; }
        public double Swtinamount { get; set; }
        public double Swtotunits { get; set; }
        public double Swtotamount { get; set; }
        public double Divunits { get; set; }
        public double Divamounts { get; set; }
        public DateTime EntryDate { get; set; }
        public double? NaVunit { get; set; }
    }
}
