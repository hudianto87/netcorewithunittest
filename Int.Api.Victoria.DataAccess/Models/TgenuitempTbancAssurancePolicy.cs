﻿using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TgenuitempTbancAssurancePolicy
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
        public long? IdbancAssurancePolicy { get; set; }
        public string? SpajNo { get; set; }
        public string? PolisNo { get; set; }
        public string? AccountNo { get; set; }
        public string? InsuredName { get; set; }
        public DateTime? InsuredDob { get; set; }
        public double? PaymentFrequency { get; set; }
        public double? BasicPremium { get; set; }
        public double? InvestPremium { get; set; }
        public DateTime? ReceiveDate { get; set; }
        public DateTime? InforceDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? EndOfCoverage { get; set; }
        public string? StatusPolis { get; set; }
        public string? KodeCabang { get; set; }
        public string? Note { get; set; }
        public string? SysCreatedBy { get; set; }
        public DateTime? SysCreatedTime { get; set; }
        public string? SysCreatedHost { get; set; }
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
        public string? SysActionType { get; set; }
        public byte? SysApprovalStatus { get; set; }
        public bool? SysRecStatus { get; set; }
        public long? Idcustomer { get; set; }
        public long? IdbancAssuranceProduct { get; set; }
        public bool? IsCancelled { get; set; }
    }
}
