using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TgenuihistTbancAssuranceFund
    {
        public long TgenuihistTableId { get; set; }
        public long TgenuijourTableId { get; set; }
        public bool SysIsAfter { get; set; }
        public long? IdbancAssuranceFund { get; set; }
        public string? FundCode { get; set; }
        public string? FundName { get; set; }
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
        public string? FundType { get; set; }
        public long? FundCurrency { get; set; }
        public int? FundProportion { get; set; }
    }
}
