using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class VUigenPmsInsuranceCoverList
    {
        public long TinsuranceCoverId { get; set; }
        public long? Idcustomer { get; set; }
        public string? Vchar1 { get; set; }
        public string? Vchar2 { get; set; }
        public double? AmountInsured { get; set; }
        public double? YearstoWork { get; set; }
        public double? MonthlyExpense { get; set; }
        public DateTime? MonthlyExpenseDate { get; set; }
        public double? Debt { get; set; }
        public double? ExpReturn { get; set; }
        public double? AdjReturn { get; set; }
        public double? RiskRate { get; set; }
        public double? TotInsRequired { get; set; }
        public double? AddiInsNeed { get; set; }
        public double? NetWorth { get; set; }
        public double? InflationRateAfter { get; set; }
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
        public string? ProfileName { get; set; }
        public string? UnitHolderIdno { get; set; }
        public string? FullName { get; set; }
    }
}
