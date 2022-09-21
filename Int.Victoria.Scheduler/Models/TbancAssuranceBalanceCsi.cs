using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TbancAssuranceBalanceCsi
    {
        public long IdbancAssuranceBalanceCsi { get; set; }
        public string Cif { get; set; } = null!;
        public DateTime BalanceDate { get; set; }
        public string? ClientAccountNo { get; set; }
        public string? ClientName { get; set; }
        public string? Idagent { get; set; }
        public string? ProductCode { get; set; }
        public string? ProductName { get; set; }
        public string? Ia { get; set; }
        public double? TotalStock { get; set; }
        public double? AveragePrice { get; set; }
        public double? TotalValueAtAveragePrice { get; set; }
        public double? ClosingPrice { get; set; }
        public double? TotalValueAtClosingPrice { get; set; }
        public double? UnRealizedGainLoss { get; set; }
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
