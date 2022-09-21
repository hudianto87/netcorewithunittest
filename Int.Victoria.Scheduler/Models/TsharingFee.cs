using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TsharingFee
    {
        public TsharingFee()
        {
            TagentProductMfeeNameNavigations = new HashSet<TagentProduct>();
            TagentProductOtherFeeNameNavigations = new HashSet<TagentProduct>();
            TagentProductRedFeeNameNavigations = new HashSet<TagentProduct>();
            TagentProductSubsFeeNameNavigations = new HashSet<TagentProduct>();
            TagentProductSwitchOutFeeNameNavigations = new HashSet<TagentProduct>();
            TagentProductSwithcInFeeNameNavigations = new HashSet<TagentProduct>();
            TproductFeeByDates = new HashSet<TproductFeeByDate>();
            TsharingFeeRules = new HashSet<TsharingFeeRule>();
        }

        public long FeeId { get; set; }
        public string FeeName { get; set; } = null!;
        public string Idstatus { get; set; } = null!;
        public int? Idcurrency { get; set; }
        public short FeeDays { get; set; }
        public string FeeType { get; set; } = null!;
        public bool? IsAumproduct { get; set; }
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

        public virtual TrefCurrency? IdcurrencyNavigation { get; set; }
        public virtual TrefStatus IdstatusNavigation { get; set; } = null!;
        public virtual ICollection<TagentProduct> TagentProductMfeeNameNavigations { get; set; }
        public virtual ICollection<TagentProduct> TagentProductOtherFeeNameNavigations { get; set; }
        public virtual ICollection<TagentProduct> TagentProductRedFeeNameNavigations { get; set; }
        public virtual ICollection<TagentProduct> TagentProductSubsFeeNameNavigations { get; set; }
        public virtual ICollection<TagentProduct> TagentProductSwitchOutFeeNameNavigations { get; set; }
        public virtual ICollection<TagentProduct> TagentProductSwithcInFeeNameNavigations { get; set; }
        public virtual ICollection<TproductFeeByDate> TproductFeeByDates { get; set; }
        public virtual ICollection<TsharingFeeRule> TsharingFeeRules { get; set; }
    }
}
