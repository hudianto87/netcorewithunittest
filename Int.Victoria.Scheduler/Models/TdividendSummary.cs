using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TdividendSummary
    {
        public TdividendSummary()
        {
            Ttransactions = new HashSet<Ttransaction>();
        }

        public long IddividendSummary { get; set; }
        public long Idproduct { get; set; }
        public DateTime DateRecorded { get; set; }
        public DateTime DateExecuted { get; set; }
        public DateTime? DateSettled { get; set; }
        public DateTime? DateReinvested { get; set; }
        public string DividendType { get; set; } = null!;
        public string EntryMode { get; set; } = null!;
        public double DistributedValue { get; set; }
        public string DividendStatus { get; set; } = null!;
        public int RecCount { get; set; }
        public short RecIsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime? LastModifiedDate { get; set; }
        public string? LastModifiedBy { get; set; }

        public virtual Tproduct IdproductNavigation { get; set; } = null!;
        public virtual ICollection<Ttransaction> Ttransactions { get; set; }
    }
}
