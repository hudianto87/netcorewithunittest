using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TcustomerCustody
    {
        public long IdcustomerCustody { get; set; }
        public long Idcustomer { get; set; }
        public int IdbankCustody { get; set; }
        public string Cifno { get; set; } = null!;
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime? LastModifiedDate { get; set; }
        public string? LastModifiedBy { get; set; }
        public string SysCreatedBy { get; set; } = null!;
        public DateTime SysCreatedTime { get; set; }
        public string SysCreatedHost { get; set; } = null!;
        public string? SysModifiedBy { get; set; }
        public DateTime? SysModifiedTime { get; set; }
        public string? SysModifiedHost { get; set; }

        public virtual TrefBankCustody IdbankCustodyNavigation { get; set; } = null!;
        public virtual Tcustomer IdcustomerNavigation { get; set; } = null!;
    }
}
