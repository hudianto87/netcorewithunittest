using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TbancAssuranceSpaj
    {
        public TbancAssuranceSpaj()
        {
            TbancAssuranceSpajfunds = new HashSet<TbancAssuranceSpajfund>();
            TbancAssuranceSpajriders = new HashSet<TbancAssuranceSpajrider>();
        }

        public long IdbancAssuranceSpaj { get; set; }
        public long IdbancAssuranceCustomer { get; set; }
        public string SpajNo { get; set; } = null!;
        public string? InsuredName { get; set; }
        public DateTime? InsureDateOfBirth { get; set; }
        public long? IdbancAssuranceProduct { get; set; }
        public double? PremiumAmount { get; set; }
        public int? Charge { get; set; }
        public int? TotalPremium { get; set; }
        public int? TotalAmount { get; set; }
        public string? BeneficaryName { get; set; }
        public bool? PremiumFrequency { get; set; }
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
        public string? Spajstatus { get; set; }
        public int? AgentId { get; set; }
        public string? ReferalCode { get; set; }
        public string? ReferalName { get; set; }

        public virtual TbancAssuranceProduct? IdbancAssuranceProductNavigation { get; set; }
        public virtual ICollection<TbancAssuranceSpajfund> TbancAssuranceSpajfunds { get; set; }
        public virtual ICollection<TbancAssuranceSpajrider> TbancAssuranceSpajriders { get; set; }
    }
}
