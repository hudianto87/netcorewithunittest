using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class VAmlCustomer
    {
        public string CifPk { get; set; } = null!;
        public string? Dcif { get; set; }
        public string? BranchCode { get; set; }
        public int AgentId { get; set; }
        public string? SaluationCode { get; set; }
        public string? FullName { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public string? PrimaryOfficer { get; set; }
        public string CustTypeCode { get; set; } = null!;
        public string? Remarks { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime CreatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? AuthorizedBy { get; set; }
        public DateTime? AuthorizedDate { get; set; }
        public string? Status { get; set; }
        public int? Hash { get; set; }
        public DateTime RiskProfileExpiredDate { get; set; }
    }
}
