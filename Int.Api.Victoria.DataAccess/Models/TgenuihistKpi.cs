using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TgenuihistKpi
    {
        public long TgenuihistTableId { get; set; }
        public long TgenuijourTableId { get; set; }
        public long Idkpi { get; set; }
        public double? Ncf { get; set; }
        public double? Revenue { get; set; }
        public double? NumberOfActiveAccount { get; set; }
        public double? ShareOfWallet { get; set; }
        public double? ComplianceAndSalesDevelopment { get; set; }
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
