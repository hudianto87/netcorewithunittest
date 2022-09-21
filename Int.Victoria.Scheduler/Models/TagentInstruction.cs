using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TagentInstruction
    {
        public int TagentInstruction1 { get; set; }
        public int AgentId { get; set; }
        public string InstructionReport { get; set; } = null!;
        public string Upname1 { get; set; } = null!;
        public string? Upname2 { get; set; }
        public string? Upname3 { get; set; }
        public string? Upaddress { get; set; }
        public string? Upphone { get; set; }
        public string? Upfax { get; set; }
        public string? Upzip { get; set; }
        public string? Upcity { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime CreatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual Tagent Agent { get; set; } = null!;
    }
}
