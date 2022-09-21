﻿using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TgenuitempTbancAssuranceBalanceSunLife
    {
        public long TgenuitempTableId { get; set; }
        public string TgenuitempSessionId { get; set; } = null!;
        public long? TgenuitempIdmaster { get; set; }
        public long? TgenuitempIddetail { get; set; }
        public short TgenuitempChangeFlag { get; set; }
        public string TgenuitempSysCreatedBy { get; set; } = null!;
        public DateTime TgenuitempSysCreatedTime { get; set; }
        public string TgenuitempSysCreatedHost { get; set; } = null!;
        public string? TgenuitempSysModifiedBy { get; set; }
        public DateTime? TgenuitempSysModifiedTime { get; set; }
        public string? TgenuitempSysModifiedHost { get; set; }
        public long? IdbancAssuranceBalanceSunLife { get; set; }
        public string? NomorRekening { get; set; }
        public string? Cif { get; set; }
        public string? CompanyName { get; set; }
        public DateTime? BalanceDt { get; set; }
        public string? ProductName { get; set; }
        public string? Idpolicy { get; set; }
        public string? Idrider { get; set; }
        public double? PremiumPaymentFrequency { get; set; }
        public double? BasicSumAssured { get; set; }
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
        public string? SysCreatedBy { get; set; }
        public DateTime? SysCreatedTime { get; set; }
        public string? SysCreatedHost { get; set; }
        public string? SysModifiedBy { get; set; }
        public DateTime? SysModifiedTime { get; set; }
        public string? SysModifiedHost { get; set; }
        public bool? IsActive { get; set; }
        public string? Remarks { get; set; }
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
