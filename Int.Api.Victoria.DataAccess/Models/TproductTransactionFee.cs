using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TproductTransactionFee
    {
        public long TproductTransactionFeeId { get; set; }
        public long Idproduct { get; set; }
        public string TrxIdcategory { get; set; } = null!;
        public string FeeName { get; set; } = null!;
        public short ChannelId { get; set; }
        public bool? IsRetail { get; set; }
        public bool? IsPrivate { get; set; }
        public bool? IsPreferred { get; set; }
        public short TrxFeeType { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime? EndDate { get; set; }
        public long TtransactionFeeId { get; set; }
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

        public virtual Tproduct IdproductNavigation { get; set; } = null!;
        public virtual TrefCategory TrxIdcategoryNavigation { get; set; } = null!;
        public virtual TtransactionFee TtransactionFee { get; set; } = null!;
    }
}
