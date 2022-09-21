using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TbancAssurancePolicyBalance
    {
        public long IdbancAssurancePolicyBalance { get; set; }
        public long? IdbancAssurancePolicy { get; set; }
        public double BasicPremium { get; set; }
        public double InvestPremium { get; set; }
        public DateTime ReceiveDate { get; set; }
        public DateTime? InforceDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime EndOfCoverage { get; set; }
        public DateTime? LastPayment { get; set; }
        public DateTime? NextPaymentDate { get; set; }
        public double TotalPremium { get; set; }
        public double? SumInsured { get; set; }
        public double? TotPertanggunganDibayar { get; set; }
        public double? AkumulasiPremiSejakAwal { get; set; }
        public double AkumulasiFeeBaseIncome { get; set; }
        public string StatusPolis { get; set; } = null!;
        public string KodeCabang { get; set; } = null!;
        public string? Note { get; set; }
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

        public virtual TbancAssurancePolicy? IdbancAssurancePolicyNavigation { get; set; }
    }
}
