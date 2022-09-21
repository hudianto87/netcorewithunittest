using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TrefOccupation
    {
        public string Idoccupation { get; set; } = null!;
        public string? OccupationName { get; set; }
        public string? IdbankCustody { get; set; }
        public string? CustodyOcc { get; set; }
        public string? OccupationType { get; set; }
        public string? FwPrefix { get; set; }
        public DateTime? FwTimeStamp { get; set; }
        public string? FwReference { get; set; }
    }
}
