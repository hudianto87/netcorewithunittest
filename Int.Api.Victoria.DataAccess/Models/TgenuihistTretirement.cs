using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TgenuihistTretirement
    {
        public long TgenuihistTableId { get; set; }
        public long TgenuijourTableId { get; set; }
        public bool SysIsAfter { get; set; }
        public long? TretirementId { get; set; }
        public long? Idcustomer { get; set; }
        public int? Age { get; set; }
        public int? YearRetirement { get; set; }
        public int? LifeExpected { get; set; }
        public double? Salary { get; set; }
        public double? AnnualIncrease { get; set; }
        public double? MonthExpense { get; set; }
        public double? OtherAnnExpense { get; set; }
        public double? RateInfBefore { get; set; }
        public double? RateInfAfter { get; set; }
        public double? IntAfter { get; set; }
        public double? IntBefore { get; set; }
        public double? InvestAmount { get; set; }
        public double? RateInvest { get; set; }
        public double? OtherIncome1 { get; set; }
        public int? Start1 { get; set; }
        public int? End1 { get; set; }
        public double? Increase1 { get; set; }
        public double? Otherincome2 { get; set; }
        public int? Start2 { get; set; }
        public int? End2 { get; set; }
        public double? Increase2 { get; set; }
        public double? Debt { get; set; }
        public int? StartDebt { get; set; }
        public int? EndDebt { get; set; }
        public double? InvGrow { get; set; }
        public double? PostTaxMonthly { get; set; }
        public double? CorpusRequired { get; set; }
        public double? InitialMonthly { get; set; }
        public double? OtherNeeds { get; set; }
        public string? CurrentYear { get; set; }
        public string? SysCreatedBy { get; set; }
        public DateTime? SysCreatedTime { get; set; }
        public string? SysCreatedHost { get; set; }
        public string? SysModifiedBy { get; set; }
        public DateTime? SysModifiedTime { get; set; }
        public string? SysModifiedHost { get; set; }
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
