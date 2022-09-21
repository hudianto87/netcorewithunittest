using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TprodProduct
    {
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public int? FundTypeId { get; set; }
        public int? LegalTypeId { get; set; }
        public int? PfolioOwnerId { get; set; }
        public int? FundManagerId { get; set; }
        public DateTime? LaunchDate { get; set; }
        public DateTime? MaturityDate { get; set; }
        public string? ProductConcept { get; set; }
        public string? ProductCard { get; set; }
        public int? ProductStatusId { get; set; }
        public int? CustodianId { get; set; }
        public string? Allocation { get; set; }
        public string? InvestCard { get; set; }
        public int? CrmaccountManagerId { get; set; }
        public int? ClientReporterBackupId { get; set; }
    }
}
