using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class Tagent
    {
        public Tagent()
        {
            TagentAddresses = new HashSet<TagentAddress>();
            TagentAuthContacts = new HashSet<TagentAuthContact>();
            TagentBankAccounts = new HashSet<TagentBankAccount>();
            TagentCustomers = new HashSet<TagentCustomer>();
            TagentInstructions = new HashSet<TagentInstruction>();
            TagentProducts = new HashSet<TagentProduct>();
            TagentTreeAgents = new HashSet<TagentTreeAgent>();
            TcustomerSalesHistories = new HashSet<TcustomerSalesHistory>();
            TmarketingHistories = new HashSet<TmarketingHistory>();
            ToutStandingHistoryFifos = new HashSet<ToutStandingHistoryFifo>();
            TtransactionIdbranchNavigations = new HashSet<Ttransaction>();
            TtransactionIdsalesNavigations = new HashSet<Ttransaction>();
        }

        public int AgentId { get; set; }
        public int? AgentLevelId { get; set; }
        public string Idstatus { get; set; } = null!;
        public string? CodeAgent { get; set; }
        public string? ParentAgent { get; set; }
        public string? NameAgent { get; set; }
        public string? OtherNameAgent { get; set; }
        public string? IdtypeAgent { get; set; }
        public bool? ChannelType { get; set; }
        public bool? TxFeeMethod { get; set; }
        public double? CalcFeeMethod { get; set; }
        public DateTime? ActivateDate { get; set; }
        public string? ActivateBy { get; set; }
        public DateTime? DeactivateDate { get; set; }
        public string? DeactivateBy { get; set; }
        public DateTime? RejectDate { get; set; }
        public string? RejectBy { get; set; }
        public string AgentBrokerFlag { get; set; } = null!;
        public string? AgentType { get; set; }
        public string? Sex { get; set; }
        public string? Idmarital { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? Idnationality { get; set; }
        public string? Npwp { get; set; }
        public string? MotherName { get; set; }
        public string? Beneficiaries { get; set; }
        public string? Idoccupation { get; set; }
        public bool? Employee { get; set; }
        public string? Idtype { get; set; }
        public string? Idnumber { get; set; }
        public DateTime? Idissue { get; set; }
        public DateTime? Idexpired { get; set; }
        public string? OfficePhone { get; set; }
        public string? Fax { get; set; }
        public string? MobilePhone { get; set; }
        public string? InstitutionalType { get; set; }
        public int? GroupId { get; set; }
        public string? CodeAgentOld { get; set; }
        public bool? IsPph { get; set; }
        public string? Glcode { get; set; }
        public int? Signature { get; set; }
        public string? Aliasagent { get; set; }
        public string? RefAgent { get; set; }
        public string? OfficerAgent { get; set; }
        public string? RefAgentName { get; set; }
        public string? OfficerAgentName { get; set; }
        public string? Idname { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? WaperdNo { get; set; }
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
        public DateTime? WaperdExpiredDate { get; set; }
        public bool? IsPpn { get; set; }
        public double? Salary { get; set; }
        public DateTime? Effsalary { get; set; }
        public bool? IsReguler { get; set; }
        public bool? IsPrivate { get; set; }
        public bool? IsPrefered { get; set; }
        public string? KodeKantor { get; set; }
        public string? FormatSk { get; set; }
        public string? NomorSk { get; set; }
        public DateTime? TanggalSk { get; set; }
        public string? Nik { get; set; }
        public DateTime? WaperdstartDate { get; set; }
        public string? Waperdpp { get; set; }
        public string? Waperdformat { get; set; }
        public DateTime? AajistartDate { get; set; }
        public DateTime? AajiexpiredDate { get; set; }
        public string? Aajipp { get; set; }
        public string? Aajino { get; set; }
        public string? Aajiformat { get; set; }
        public DateTime? WppestartDate { get; set; }
        public DateTime? WppeexpiredDate { get; set; }
        public string? Wppepp { get; set; }
        public string? Wppeno { get; set; }
        public string? Wppeformat { get; set; }
        public string? Remarks { get; set; }
        public string? ContactPerson { get; set; }
        public string? Bic { get; set; }

        public virtual TagentLevel? AgentLevel { get; set; }
        public virtual ICollection<TagentAddress> TagentAddresses { get; set; }
        public virtual ICollection<TagentAuthContact> TagentAuthContacts { get; set; }
        public virtual ICollection<TagentBankAccount> TagentBankAccounts { get; set; }
        public virtual ICollection<TagentCustomer> TagentCustomers { get; set; }
        public virtual ICollection<TagentInstruction> TagentInstructions { get; set; }
        public virtual ICollection<TagentProduct> TagentProducts { get; set; }
        public virtual ICollection<TagentTreeAgent> TagentTreeAgents { get; set; }
        public virtual ICollection<TcustomerSalesHistory> TcustomerSalesHistories { get; set; }
        public virtual ICollection<TmarketingHistory> TmarketingHistories { get; set; }
        public virtual ICollection<ToutStandingHistoryFifo> ToutStandingHistoryFifos { get; set; }
        public virtual ICollection<Ttransaction> TtransactionIdbranchNavigations { get; set; }
        public virtual ICollection<Ttransaction> TtransactionIdsalesNavigations { get; set; }
    }
}
