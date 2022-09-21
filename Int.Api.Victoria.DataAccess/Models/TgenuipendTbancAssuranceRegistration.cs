﻿using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TgenuipendTbancAssuranceRegistration
    {
        public long? IdbancAssuranceRegistration { get; set; }
        public string? SalesCode { get; set; }
        public string? SalesName { get; set; }
        public string? ReferalCode { get; set; }
        public string? ReferalName { get; set; }
        public string? BranchCode { get; set; }
        public string? BranchName { get; set; }
        public string? CustomerCif { get; set; }
        public string? CustomerName { get; set; }
        public string? BeneficaryName { get; set; }
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
    }
}
