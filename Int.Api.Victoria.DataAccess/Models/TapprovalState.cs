using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TapprovalState
    {
        public TapprovalState()
        {
            TapprovalAssignments = new HashSet<TapprovalAssignment>();
        }

        public int Id { get; set; }
        public string Description { get; set; } = null!;

        public virtual ICollection<TapprovalAssignment> TapprovalAssignments { get; set; }
    }
}
