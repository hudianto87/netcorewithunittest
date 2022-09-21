using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class Tgoal
    {
        public long TgoalId { get; set; }
        public long Idcustomer { get; set; }
        public string Value { get; set; } = null!;
        public string? Current { get; set; }
        public string Target { get; set; } = null!;
        public double? Inflation { get; set; }
        public double ValueTodaysTerm { get; set; }
        public double GoalAmount { get; set; }
        public int? YearsLeft { get; set; }
        public double? Return { get; set; }
        public double? InflationAdjusted { get; set; }
        public double? PermonthInvestment { get; set; }
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
        public double? AnnualIncrease { get; set; }

        public virtual Tcustomer IdcustomerNavigation { get; set; } = null!;
    }
}
