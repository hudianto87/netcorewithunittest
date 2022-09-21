using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TapprovalTracking
    {
        public TapprovalTracking()
        {
            TapprovalAssignments = new HashSet<TapprovalAssignment>();
        }

        public int Id { get; set; }
        public long BranchId { get; set; }
        public DateTime RequestDate { get; set; }
        public string RequestType { get; set; } = null!;
        public string TableName { get; set; } = null!;
        public string? NewValue { get; set; }
        public string? OldValue { get; set; }
        public bool IsComplete { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime CreatedDate { get; set; }

        public virtual ICollection<TapprovalAssignment> TapprovalAssignments { get; set; }
    }
}
