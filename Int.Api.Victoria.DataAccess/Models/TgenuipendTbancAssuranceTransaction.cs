using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TgenuipendTbancAssuranceTransaction
    {
        public long IdbancAssuranceTransaction { get; set; }
        public long? IdbancAssurancePolicy { get; set; }
        public string? AccountNo { get; set; }
        public string? CurrencyCode { get; set; }
        public double? Amount { get; set; }
        public double? SettlementAmount { get; set; }
        public DateTime? SettlementDate { get; set; }
        public string? ReferenceNo { get; set; }
        public double? PaymentNo { get; set; }
        public string? StatusCode { get; set; }
        public string? KodeBiller { get; set; }
        public DateTime? TransactionDate { get; set; }
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
        public string? BillerCode { get; set; }
        public DateTime? TransactionDate1 { get; set; }
        public bool? IsCancelled { get; set; }
    }
}
