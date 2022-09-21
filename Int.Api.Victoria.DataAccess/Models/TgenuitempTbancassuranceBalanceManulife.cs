using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TgenuitempTbancassuranceBalanceManulife
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
        public long? IdbancassuranceBalanceManulife { get; set; }
        public DateTime? SubmittedDate { get; set; }
        public DateTime? TanggalSaldo { get; set; }
        public string? PolicyNo { get; set; }
        public string? PemegangPolis { get; set; }
        public string? Tertanggung { get; set; }
        public double? Premium { get; set; }
        public DateTime? JatuhTempoPolis { get; set; }
        public string? Produk { get; set; }
        public double? Navopen { get; set; }
        public double? Navcurrent { get; set; }
        public double? SaldoAkhir { get; set; }
        public DateTime? SwitchDate { get; set; }
        public double? TotalUnit { get; set; }
        public string? PolicyStatus { get; set; }
        public string? Currency { get; set; }
        public double? CashValue { get; set; }
        public double? InvestmentValue { get; set; }
        public double? TotalInvestment { get; set; }
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
        public string? Cifv10 { get; set; }
    }
}
