using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TcustomerShareholder
    {
        public long TcustomerShareholderId { get; set; }
        public long Idcustomer { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public string? Idnationality { get; set; }
        public double? SharePercentage { get; set; }
        public string? Remarks { get; set; }
        public string SysCreatedBy { get; set; } = null!;
        public DateTime SysCreatedTime { get; set; }
        public string SysCreatedHost { get; set; } = null!;
        public string? SysModifiedBy { get; set; }
        public DateTime? SysModifiedTime { get; set; }
        public string? SysModifiedHost { get; set; }

        public virtual Tcustomer IdcustomerNavigation { get; set; } = null!;
    }
}
