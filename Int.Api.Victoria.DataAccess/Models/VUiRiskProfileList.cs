using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class VUiRiskProfileList
    {
        public long? TcustomerRiskProfileId { get; set; }
        public long Idcustomer { get; set; }
        public string UnitHolderIdno { get; set; } = null!;
        public string? FullName { get; set; }
        public string? Idstatus { get; set; }
        public string InvestorType { get; set; } = null!;
        public DateTime? EffectiveDate { get; set; }
        public DateTime? ExpireDate { get; set; }
        public int? ProfileScore { get; set; }
        public int? ProfileId { get; set; }
        public string? ProfileShortName { get; set; }
        public string? SysActionType { get; set; }
        public byte? SysApprovalStatus { get; set; }
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
    }
}
