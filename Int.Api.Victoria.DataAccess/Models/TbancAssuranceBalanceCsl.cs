using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TbancAssuranceBalanceCsl
    {
        public long IdbancAssuranceBalanceCsl { get; set; }
        public string CompanyName { get; set; } = null!;
        public string Cif { get; set; } = null!;
        public DateTime BalanceDate { get; set; }
        public string? Idproduct { get; set; }
        public string? Idpolicy { get; set; }
        public string? IdpolicyHolderName { get; set; }
        public string? PolicyInsuredName { get; set; }
        public string? Rmname { get; set; }
        public string? BranchName { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public DateTime? MaturityDate { get; set; }
        public string? Idcurrency { get; set; }
        public double? SinglePremium { get; set; }
        public double? TopUpInitial { get; set; }
        public double? TotalPremium { get; set; }
        public string? Idfund1 { get; set; }
        public double? UnitBalance1 { get; set; }
        public double? Nav1 { get; set; }
        public string? Idfund2 { get; set; }
        public double? UnitBalance2 { get; set; }
        public double? Nav2 { get; set; }
        public string? Idfund3 { get; set; }
        public double? UnitBalance3 { get; set; }
        public double? Nav3 { get; set; }
        public string? Idfund4 { get; set; }
        public double? UnitBalance4 { get; set; }
        public double? Nav4 { get; set; }
        public string SysCreatedBy { get; set; } = null!;
        public DateTime SysCreatedTime { get; set; }
        public string SysCreatedHost { get; set; } = null!;
        public string? SysModifiedBy { get; set; }
        public DateTime? SysModifiedTime { get; set; }
        public string? SysModifiedHost { get; set; }
        public bool? IsActive { get; set; }
        public string? Remarks { get; set; }
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
    }
}
