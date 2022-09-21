using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TrefCabang
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string? AgentTypeId { get; set; }
        public string? Grade { get; set; }
    }
}
