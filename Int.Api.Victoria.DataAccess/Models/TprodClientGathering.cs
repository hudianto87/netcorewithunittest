using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TprodClientGathering
    {
        public int ClientGatheringId { get; set; }
        public string? ClientGatheringName { get; set; }
        public int? DistributorId { get; set; }
        public string? Product { get; set; }
        public DateTime? GatheringDate { get; set; }
        public string? GatheringVenue { get; set; }
    }
}
