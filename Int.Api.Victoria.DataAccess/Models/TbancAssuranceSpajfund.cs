﻿using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TbancAssuranceSpajfund
    {
        public long IdbancAssuranceSpajfund { get; set; }
        public long IdbancAssuranceSpaj { get; set; }
        public long IdbancAssuranceFund { get; set; }
        public DateTime NavDate { get; set; }
        public double Nav { get; set; }
        public double Unit { get; set; }
        public double Amount { get; set; }
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

        public virtual TbancAssuranceFund IdbancAssuranceFundNavigation { get; set; } = null!;
        public virtual TbancAssuranceSpaj IdbancAssuranceSpajNavigation { get; set; } = null!;
    }
}