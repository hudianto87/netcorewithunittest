using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TbancAssuranceRegistrationDetail
    {
        public long IdbancAssuranceRegistrationDetail { get; set; }
        public long IdbancAssuranceRegistration { get; set; }
        public int SpajNo { get; set; }
        public string PolicyHolderName { get; set; } = null!;
        public string? InsuredName { get; set; }
        public DateTime? InsureDateOfBirth { get; set; }
        public string? ProductCode { get; set; }
        public string? ProductName { get; set; }
        public string? InsuranceCompany { get; set; }
        public int? Currency { get; set; }
        public int? PremiumAmount { get; set; }
        public string? RiderName { get; set; }
        public string? RiderPremium { get; set; }
        public string? FundName { get; set; }
        public string? Percentage { get; set; }
        public int? Charge { get; set; }
        public int? TotalPremium { get; set; }
        public int? TotalAmount { get; set; }
        public string SysCreatedBy { get; set; } = null!;
        public DateTime? SysCreatedTime { get; set; }
        public string SysCreatedHost { get; set; } = null!;
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
        public string SysActionType { get; set; } = null!;
        public byte SysApprovalStatus { get; set; }
        public bool SysRecStatus { get; set; }
    }
}
