using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TgenuitempTbancAssuranceProductRule
    {
        public long TgenuitempTableId { get; set; }
        public string TgenuitempSessionId { get; set; } = null!;
        public long? TgenuitempIdmaster { get; set; }
        public long? TgenuitempIddetail { get; set; }
        public short TgenuitempChangeFlag { get; set; }
        public string TgenuitempSysCreatedBy { get; set; } = null!;
        public DateTime TgenuitempSysCreatedTime { get; set; }
        public string TgenuitempSysCreatedHost { get; set; } = null!;
        public string? TgenuitempSysModifiedBy { get; set; }
        public DateTime? TgenuitempSysModifiedTime { get; set; }
        public string? TgenuitempSysModifiedHost { get; set; }
        public long? IdbancAssuranceProductRule { get; set; }
        public long? IdbancAssuranceProduct { get; set; }
        public int? MinimumPremium { get; set; }
        public int? AllowPremiumTopUp { get; set; }
        public int? MaximumInsuredAmount { get; set; }
        public int? MinimumAgePolicyHolderYear { get; set; }
        public int? MinimumEntryAgeInsuredYear { get; set; }
        public int? MaximumEntryAgeInsuredYear { get; set; }
        public int? FreeLookPeriodDay { get; set; }
        public int? GracePeriodDay { get; set; }
        public int? PaymentPeriodYear { get; set; }
        public string? AccountName { get; set; }
        public int? AccountNumber { get; set; }
        public string? SysCreatedBy { get; set; }
        public DateTime? SysCreatedTime { get; set; }
        public string? SysCreatedHost { get; set; }
        public string? SysModifiedBy { get; set; }
        public DateTime? SysModifiedTime { get; set; }
        public string? SysModifiedHost { get; set; }
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
        public string? SysActionType { get; set; }
        public byte? SysApprovalStatus { get; set; }
        public bool? SysRecStatus { get; set; }
    }
}
