using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TcustProfileExt
    {
        public string UnitHolderIdno { get; set; } = null!;
        public long? IdCustomer { get; set; }
        public string? RecordCode { get; set; }
        public string? PolisNo { get; set; }
        public DateTime? PaidToDate { get; set; }
        public double? TotalPremi { get; set; }
        public double? PercentageRd { get; set; }
        public double? PremiumRd { get; set; }
        public DateTime? InsuranceDateStart { get; set; }
        public DateTime? NextPostingDate { get; set; }
        public string? PremiumType { get; set; }
        public string? PolisStatus { get; set; }
        public DateTime? InsuranceDateFinish { get; set; }
        public string? BatchCode { get; set; }
        public string? JobName { get; set; }
        public string? UserProfile { get; set; }
        public DateTime? SystemDate { get; set; }
        public string? Idtransaction { get; set; }
        public double? Premium { get; set; }
        public string? TransactionType { get; set; }
        public DateTime? IssuedDate { get; set; }
        public DateTime? PostingDate { get; set; }
        public DateTime? EffDate { get; set; }
        public DateTime? MaturityDate { get; set; }
        public string? FwPrefix { get; set; }
        public DateTime? FwTimeStamp { get; set; }
    }
}
