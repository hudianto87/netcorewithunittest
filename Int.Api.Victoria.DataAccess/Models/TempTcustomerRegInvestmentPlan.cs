using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TempTcustomerRegInvestmentPlan
    {
        public long TcustomerRegInvestmentPlanId { get; set; }
        public long TregularInvestmentPlanId { get; set; }
        public string? ReferenceNo { get; set; }
        public long Idproduct { get; set; }
        public long Idcustomer { get; set; }
        public long Idsales { get; set; }
        public string CustAccountNo { get; set; } = null!;
        public int Tenor { get; set; }
        public double Amount { get; set; }
        public double Fee { get; set; }
        public double FeeTax { get; set; }
        public double FeeAmount { get; set; }
        public double NetAmount { get; set; }
        public string FeeMethod { get; set; } = null!;
        public string AdjustFeeType { get; set; } = null!;
        public DateTime RegDate { get; set; }
        public byte DebitDate { get; set; }
        public DateTime? BreakDate { get; set; }
        public bool? IsBreak { get; set; }
        public short? GeneratorId { get; set; }
        public string? GeneratorData1 { get; set; }
        public string? GeneratorData2 { get; set; }
        public string? GeneratorData3 { get; set; }
        public string? Remarks { get; set; }
        public string SysCreatedBy { get; set; } = null!;
        public DateTime SysCreatedTime { get; set; }
        public string SysCreatedHost { get; set; } = null!;
        public string? SysModifiedBy { get; set; }
        public DateTime? SysModifiedTime { get; set; }
        public string? SysModifiedHost { get; set; }
        public string SysActionType { get; set; } = null!;
        public byte SysApprovalStatus { get; set; }
        public bool SysRecStatus { get; set; }
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
        public long? IdsubAccount { get; set; }
        public DateTime? MaturityDate { get; set; }
        public double? FailCounter { get; set; }
    }
}
