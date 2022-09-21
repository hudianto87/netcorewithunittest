using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TbalanceCustody
    {
        public string? ProductCode { get; set; }
        public DateTime? NavDate { get; set; }
        public string? Name { get; set; }
        public string? JointName { get; set; }
        public string? MailingAddress { get; set; }
        public string? MailingCity { get; set; }
        public string? Nationality { get; set; }
        public string? PostCode { get; set; }
        public string? Description { get; set; }
        public string? InvestorNo { get; set; }
        public double? NoShares { get; set; }
        public decimal? FirstAlocationDate { get; set; }
        public string? BranchCode { get; set; }
        public double? NavPerUnit { get; set; }
        public double? Amount { get; set; }
        public string? FwPrefix { get; set; }
        public DateTime? FwTimeStamp { get; set; }
        public long IdbalanceCustody { get; set; }
        public string? CustomerNameTrim { get; set; }
    }
}
