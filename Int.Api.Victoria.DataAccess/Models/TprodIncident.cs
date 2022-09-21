using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TprodIncident
    {
        public int IncidentId { get; set; }
        public string? IncidentName { get; set; }
        public int? ProductId { get; set; }
        public DateTime? IncidentDate { get; set; }
        public string? Description { get; set; }
        public string? ActionTaken { get; set; }
        public string? PartiesInvolved { get; set; }
        public DateTime? SolutionDate { get; set; }
    }
}
