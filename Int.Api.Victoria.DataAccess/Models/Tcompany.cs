using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class Tcompany
    {
        public int Idcompany { get; set; }
        public long TrefSinvestParticipantTypeId { get; set; }
        public string CompanyCode { get; set; } = null!;
        public string CompanyName { get; set; } = null!;
        public string Address1 { get; set; } = null!;
        public string? Phone { get; set; }
        public string? CountryCode { get; set; }
        public string? Address2 { get; set; }
        public string? Fax { get; set; }
        public string? Logo { get; set; }
        public string? PostalCode { get; set; }
        public string? City { get; set; }
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
        public string? KodeAgenPenjual { get; set; }
        public string? ExternalCode { get; set; }

        public virtual TrefSinvestParticipantType TrefSinvestParticipantType { get; set; } = null!;
    }
}
