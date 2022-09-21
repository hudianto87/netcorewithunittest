using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TassetTransfer
    {
        public long IdassetTransfer { get; set; }
        public long FromIdcustomer { get; set; }
        public long ToIdcustomer { get; set; }
        public long Idproduct { get; set; }
        public double? Amount { get; set; }
        public double? Unit { get; set; }
        public DateTime? NavDate { get; set; }
        public double? NavValue { get; set; }
        public string TransferType { get; set; } = null!;
        public DateTime TransferDate { get; set; }
        public string? Status { get; set; }
        public long? IdtransactionOut { get; set; }
        public long? IdtransactionIn { get; set; }
        public long IdsubAccount { get; set; }
        public long IdsubAccountTo { get; set; }
        public string SysCreatedBy { get; set; } = null!;
        public DateTime SysCreatedTime { get; set; }
        public string SysCreatedHost { get; set; } = null!;
        public string? SysModifiedBy { get; set; }
        public DateTime? SysModifiedTime { get; set; }
        public string? SysModifiedHost { get; set; }
        public string? SysApprovedBy { get; set; }
        public DateTime? SysApprovedTime { get; set; }
        public string? SysApprovedHost { get; set; }
        public string? SysUnApprovedBy { get; set; }
        public DateTime? SysUnApprovedTime { get; set; }
        public string? SysUnApprovedHost { get; set; }
        public string? SysSettledBy { get; set; }
        public DateTime? SysSettledTime { get; set; }
        public string? SysSettledHost { get; set; }

        public virtual Tcustomer FromIdcustomerNavigation { get; set; } = null!;
        public virtual Tproduct IdproductNavigation { get; set; } = null!;
        public virtual TsubAccount IdsubAccountNavigation { get; set; } = null!;
        public virtual Tcustomer ToIdcustomerNavigation { get; set; } = null!;
    }
}
