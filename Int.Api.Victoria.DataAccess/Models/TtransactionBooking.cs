using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TtransactionBooking
    {
        public long IdtransactionBooking { get; set; }
        public string Idcategory { get; set; } = null!;
        public string Idstatus { get; set; } = null!;
        public string? ReferenceNo { get; set; }
        public long? IdsubAccount { get; set; }
        public long? Idcustomer { get; set; }
        public long? Idproduct { get; set; }
        public long? Idsales { get; set; }
        public DateTime? TransactionDate { get; set; }
        public DateTime? Navdate { get; set; }
        public double? Navvalue { get; set; }
        public double? OutstandingUnit { get; set; }
        public double? OutstandingAmount { get; set; }
        public double? Units { get; set; }
        public double? Amount { get; set; }
        public double? Fee { get; set; }
        public double? FeeAmount { get; set; }
        public double? NetAmount { get; set; }
        public double? Charges { get; set; }
        public bool? IsRedemAll { get; set; }
        public string? PaymentMethod { get; set; }
        public string? FeeMethod { get; set; }
        public byte? InputMode { get; set; }
        public double? Percentage { get; set; }
        public string? Remarks { get; set; }
        public string CustAccountNo { get; set; } = null!;
        public string? CustAccountName { get; set; }
        public int? CustIdcurrency { get; set; }
        public int? CustIdbankBranch { get; set; }
        public string ProdAccountNo { get; set; } = null!;
        public string? ProdAccountName { get; set; }
        public int? ProdIdcurrency { get; set; }
        public int? ProdIdbankBranch { get; set; }
        public string SysCreatedBy { get; set; } = null!;
        public DateTime SysCreatedTime { get; set; }
        public string SysCreatedHost { get; set; } = null!;
        public string? SysModifiedBy { get; set; }
        public DateTime? SysModifiedTime { get; set; }
        public string? SysModifiedHost { get; set; }
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
        public long? HoldId { get; set; }
        public bool? IsWaiver { get; set; }
    }
}
