using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TagentHistory
    {
        public string CodeAgent { get; set; } = null!;
        public string? ParentAgent { get; set; }
        public string? NameAgent { get; set; }
        public string? IdtypeAgent { get; set; }
        public bool? ChannelType { get; set; }
        public bool? TxFeeMethod { get; set; }
        public double? CalcFeeMethod { get; set; }
        public string? Idstatus { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreateBy { get; set; }
        public DateTime? ActivateDate { get; set; }
        public string? ActivateBy { get; set; }
        public DateTime? DeactivateDate { get; set; }
        public string? DeactivateBy { get; set; }
        public DateTime? RejectDate { get; set; }
        public string? RejectBy { get; set; }
        public string? AgentBrokerFlag { get; set; }
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
        public string? HomeAddress { get; set; }
        public string? HomeCity { get; set; }
        public string? HomeCountry { get; set; }
        public string? HomeZip { get; set; }
        public string? HomePhone { get; set; }
        public string? OfficePhone { get; set; }
        public string? Fax { get; set; }
        public string? Email { get; set; }
        public string? MobilePhone { get; set; }
        public string? MailAddress { get; set; }
        public string? MailCity { get; set; }
        public string? MailCountry { get; set; }
        public string? MailZip { get; set; }
        public string? InstitutionalType { get; set; }
        public int? GroupId { get; set; }
        public string? CodeAgentOld { get; set; }
        public string? LogUser { get; set; }
        public DateTime? LogDate { get; set; }
        public bool? IsPph { get; set; }
        public string? GlagentCode { get; set; }
    }
}
