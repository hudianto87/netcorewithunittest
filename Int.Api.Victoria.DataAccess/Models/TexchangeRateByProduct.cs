using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TexchangeRateByProduct
    {
        public long TexchangeRateByProductId { get; set; }
        public long Idproduct { get; set; }
        public int CcurrencyId { get; set; }
        public int TcurrencyId { get; set; }
        public double Bid { get; set; }
        public double Offer { get; set; }
        public DateTime Erdate { get; set; }
        public string? Remarks { get; set; }
        public string SysCreatedBy { get; set; } = null!;
        public DateTime SysCreatedTime { get; set; }
        public string SysCreatedHost { get; set; } = null!;
        public string? SysModifiedBy { get; set; }
        public DateTime? SysModifiedTime { get; set; }
        public string? SysModifiedHost { get; set; }
        public string SysActionType { get; set; } = null!;
        public byte SysApprovalStatus { get; set; }
        public bool? SysRecStatus { get; set; }
        public string? SysPendingBy { get; set; }
        public DateTime? SysPendingTime { get; set; }
        public string? SysPendingHost { get; set; }
        public string? SysApprovalNotes { get; set; }
        public string? SysApprovedBy { get; set; }
        public DateTime? SysApprovedTime { get; set; }
        public string? SysApprovedHost { get; set; }
        public string? SysDeletedBy { get; set; }
        public DateTime? SysDeletedTime { get; set; }
        public string? SysDeletedHost { get; set; }

        public virtual TrefCurrency Ccurrency { get; set; } = null!;
        public virtual Tproduct IdproductNavigation { get; set; } = null!;
        public virtual TrefCurrency Tcurrency { get; set; } = null!;
    }
}
