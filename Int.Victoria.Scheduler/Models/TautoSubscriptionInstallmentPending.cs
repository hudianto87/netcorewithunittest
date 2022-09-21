using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TautoSubscriptionInstallmentPending
    {
        public int RegisterId { get; set; }
        public string Cifno { get; set; } = null!;
        public string AccountNumber { get; set; } = null!;
        public string SalesCode { get; set; } = null!;
        public string BranchCode { get; set; } = null!;
        public string ProductCode { get; set; } = null!;
        public double InvestmentAmount { get; set; }
        public double FeeAmount { get; set; }
        public double? PercentageFee { get; set; }
        public double? DebitAmount { get; set; }
        public double? SubscriptionAmount { get; set; }
        public string? FeeType { get; set; }
        public string? Term { get; set; }
        public bool IsActive { get; set; }
        public byte DebitDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? CloseDate { get; set; }
        public string? ApprovalStatus { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public string? ApprovalUser { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime? LastModifedDate { get; set; }
        public string? LastModifiedBy { get; set; }
    }
}
