using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TgenuitempTbancAssuranceBalanceAium
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
        public int? TbancAssuranceBalanceAiaId { get; set; }
        public string? Cif { get; set; }
        public string? NoRek { get; set; }
        public string? InsCompCode { get; set; }
        public string? HolderName { get; set; }
        public string? Cifpayor { get; set; }
        public string? PayorName { get; set; }
        public string? InsurancedName { get; set; }
        public DateTime? BalanceDate { get; set; }
        public string? ProductCode { get; set; }
        public string? ProductName { get; set; }
        public string? Spajno { get; set; }
        public string? PolicyNo { get; set; }
        public string? Status { get; set; }
        public string? ReferralName { get; set; }
        public string? ReferralBranch { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public DateTime? MaturityDate { get; set; }
        public DateTime? SubmissionDate { get; set; }
        public DateTime? RiskCommenceDate { get; set; }
        public string? Kurs { get; set; }
        public int? PaymentMethod { get; set; }
        public string? SettleAcc { get; set; }
        public double? Premium { get; set; }
        public double? InitialTopupReg { get; set; }
        public double? TotalPremi { get; set; }
        public DateTime? NextPaymentDate { get; set; }
        public double? LastPaidPremium { get; set; }
        public double? CashValue { get; set; }
        public DateTime? SwitchDate { get; set; }
        public double? SumInsured { get; set; }
        public string? SysCreatedBy { get; set; }
        public DateTime? SysCreatedTime { get; set; }
        public string? SysCreatedHost { get; set; }
        public string? SysModifiedBy { get; set; }
        public DateTime? SysModifiedTime { get; set; }
        public string? SysModifiedHost { get; set; }
        public bool? IsActive { get; set; }
        public string? Remarks { get; set; }
        public string? SysActionType { get; set; }
        public byte? SysApprovalStatus { get; set; }
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
    }
}
