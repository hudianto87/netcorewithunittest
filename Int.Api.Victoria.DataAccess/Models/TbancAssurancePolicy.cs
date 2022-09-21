using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TbancAssurancePolicy
    {
        public TbancAssurancePolicy()
        {
            TbancAssuranceFundBalances = new HashSet<TbancAssuranceFundBalance>();
            TbancAssurancePolicyBalances = new HashSet<TbancAssurancePolicyBalance>();
            TbancAssuranceRiderPremis = new HashSet<TbancAssuranceRiderPremi>();
            TbancAssuranceTransactions = new HashSet<TbancAssuranceTransaction>();
        }

        public long IdbancAssurancePolicy { get; set; }
        public string SpajNo { get; set; } = null!;
        public string PolisNo { get; set; } = null!;
        public string AccountNo { get; set; } = null!;
        public string InsuredName { get; set; } = null!;
        public DateTime InsuredDob { get; set; }
        public double PaymentFrequency { get; set; }
        public double BasicPremium { get; set; }
        public double InvestPremium { get; set; }
        public DateTime ReceiveDate { get; set; }
        public DateTime? InforceDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime EndOfCoverage { get; set; }
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
        public long? Idcustomer { get; set; }
        public long? IdbancAssuranceProduct { get; set; }
        public bool? IsCancelled { get; set; }

        public virtual TbancAssuranceProduct? IdbancAssuranceProductNavigation { get; set; }
        public virtual ICollection<TbancAssuranceFundBalance> TbancAssuranceFundBalances { get; set; }
        public virtual ICollection<TbancAssurancePolicyBalance> TbancAssurancePolicyBalances { get; set; }
        public virtual ICollection<TbancAssuranceRiderPremi> TbancAssuranceRiderPremis { get; set; }
        public virtual ICollection<TbancAssuranceTransaction> TbancAssuranceTransactions { get; set; }
    }
}
