using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TapprovalAssignment
    {
        public int Id { get; set; }
        public int ApprovalTrackingId { get; set; }
        public string AssigningUserName { get; set; } = null!;
        public DateTime AssigningDate { get; set; }
        public string AssigningEmail { get; set; } = null!;
        public string? AssignedUserName { get; set; }
        public DateTime? AssignedDate { get; set; }
        public string? AssignedEmail { get; set; }
        public int ApprovalStateId { get; set; }

        public virtual TapprovalState ApprovalState { get; set; } = null!;
        public virtual TapprovalTracking ApprovalTracking { get; set; } = null!;
    }
}
