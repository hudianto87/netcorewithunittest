using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TlookUpClient
    {
        public long TlookUpClientId { get; set; }
        public string? Code { get; set; }
        public string? Value { get; set; }
        public string? Description { get; set; }
        public string? LookupMapping { get; set; }
        public string? SysCreatedBy { get; set; }
        public DateTime? SysCreatedTime { get; set; }
        public string? SysCreatedHost { get; set; }
        public string? SysModifiedBy { get; set; }
        public DateTime? SysModifiedTime { get; set; }
        public string? SysModifiedHost { get; set; }
    }
}
