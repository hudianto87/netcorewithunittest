using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TbancAssuranceProduct
    {
        public TbancAssuranceProduct()
        {
            TbancAssurancePolicies = new HashSet<TbancAssurancePolicy>();
            TbancAssuranceProductBankAccounts = new HashSet<TbancAssuranceProductBankAccount>();
            TbancAssuranceProductFees = new HashSet<TbancAssuranceProductFee>();
            TbancAssuranceProductFunds = new HashSet<TbancAssuranceProductFund>();
            TbancAssuranceProductRiders = new HashSet<TbancAssuranceProductRider>();
            TbancAssuranceSpajs = new HashSet<TbancAssuranceSpaj>();
        }

        public long IdbancAssuranceProduct { get; set; }
        public string ProductName { get; set; } = null!;
        public string ProductCode { get; set; } = null!;
        public long? Currency { get; set; }
        public DateTime? CutOff { get; set; }
        public DateTime? InceptionDate { get; set; }
        public long? IdbancAssurancePartner { get; set; }
        public long? BusinessModel { get; set; }
        public bool? ActiveFlag { get; set; }
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
        public bool? Yearly { get; set; }
        public bool? Monthly { get; set; }
        public bool? Quartely { get; set; }
        public bool? SemiAnually { get; set; }
        public int? IdbankBranch { get; set; }
        public int? IdaccountBankType { get; set; }
        public int? Idcurrency { get; set; }
        public string? AccountNo { get; set; }
        public string? AccountName { get; set; }
        public bool? IsMandatory { get; set; }
        public string? Idcategory { get; set; }
        public double? MinimumPremium { get; set; }
        public bool? AllowPremiumTopUp { get; set; }
        public double? MaximumInsuredAmount { get; set; }
        public int? MinimumAgePolicyHolderYear { get; set; }
        public int? MinimumEntryAgeInsuredYear { get; set; }
        public int? MaximumEntryAgeInsuredYear { get; set; }
        public int? FreeLookPeriodDay { get; set; }
        public int? GracePeriodDay { get; set; }
        public int? PaymentPeriodYear { get; set; }
        public int? YearTiering { get; set; }
        public int? SinglePremium { get; set; }
        public int? RegularPremium { get; set; }
        public int? Rider { get; set; }

        public virtual TbancAssurancePartner? IdbancAssurancePartnerNavigation { get; set; }
        public virtual ICollection<TbancAssurancePolicy> TbancAssurancePolicies { get; set; }
        public virtual ICollection<TbancAssuranceProductBankAccount> TbancAssuranceProductBankAccounts { get; set; }
        public virtual ICollection<TbancAssuranceProductFee> TbancAssuranceProductFees { get; set; }
        public virtual ICollection<TbancAssuranceProductFund> TbancAssuranceProductFunds { get; set; }
        public virtual ICollection<TbancAssuranceProductRider> TbancAssuranceProductRiders { get; set; }
        public virtual ICollection<TbancAssuranceSpaj> TbancAssuranceSpajs { get; set; }
    }
}
