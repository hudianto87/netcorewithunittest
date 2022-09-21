using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TautoSubscriptionRegister
    {
        public int RegisterId { get; set; }
        public long Idcustomer { get; set; }
        public string AccountNumber { get; set; } = null!;
        public long Idsales { get; set; }
        public long Idbranch { get; set; }
        public long Idproduct { get; set; }
        public double InvestmentAmount { get; set; }
        public double FeeAmount { get; set; }
        public double? PercentageFee { get; set; }
        public double? DebitAmount { get; set; }
        public double? SubscriptionAmount { get; set; }
        public string? FeeType { get; set; }
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
