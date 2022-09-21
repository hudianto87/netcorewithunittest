using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class Tbroker
    {
        public string CodeBroker { get; set; } = null!;
        public string? CodeAgent { get; set; }
        /// <summary>
        /// Possible values: INDIVIDUAL or INSTITUTION
        /// </summary>
        public string? TypeBroker { get; set; }
        public string? FullName { get; set; }
        /// <summary>
        /// Possible values: MALE or FEMALE
        /// </summary>
        public string? Sex { get; set; }
        public string? Idmarital { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? Idnationality { get; set; }
        public string? Npwp { get; set; }
        public string? Mothername { get; set; }
        public string? Idtype { get; set; }
        public string? Idnumber { get; set; }
        public DateTime? Idissue { get; set; }
        public DateTime? Idexpired { get; set; }
        public string? Beneficiaries { get; set; }
        public string? Idoccupation { get; set; }
        public short? Employee { get; set; }
        public string? HomeAddress { get; set; }
        public string? HomeCity { get; set; }
        public string? HomeCountry { get; set; }
        public string? HomeZip { get; set; }
        public string? MailAddress { get; set; }
        public string? MailCity { get; set; }
        public string? MailCountry { get; set; }
        public string? MailZip { get; set; }
        public string? HomePhone { get; set; }
        public string? OfficePhone { get; set; }
        public string? Fax { get; set; }
        public string? Email { get; set; }
        public string? Idstatus { get; set; }
    }
}
