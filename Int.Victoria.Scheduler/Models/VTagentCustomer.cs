using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class VTagentCustomer
    {
        public long? IdagentCustomer { get; set; }
        public long Idcustomer { get; set; }
        public string? FullName { get; set; }
        public string UnitHolderIdno { get; set; } = null!;
        public DateTime? EffDate { get; set; }
        public int? AgentId { get; set; }
        public string? AgentTreeCode { get; set; }
        public string? NameAgent { get; set; }
        public string? CustomerStatus { get; set; }
        public string CustomerEmail { get; set; } = null!;
        public long? CustomerStructureId { get; set; }
        public long? AgentStructureId { get; set; }
    }
}
