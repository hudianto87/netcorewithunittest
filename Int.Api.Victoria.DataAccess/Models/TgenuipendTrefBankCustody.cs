using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TgenuipendTrefBankCustody
    {
        public int? IdbankCustody { get; set; }
        public string? CustodyCode { get; set; }
        public string? CustodyName { get; set; }
        public string? UnitHolderCode { get; set; }
        public string? CustodyStreet { get; set; }
        public string? CustodyCity { get; set; }
        public string? CustodyPhone { get; set; }
        public string? CustodyFax { get; set; }
        public string? CustodyZip { get; set; }
        public string? ContactPerson { get; set; }
        public string? ExternalCode { get; set; }
        public string? Bicode { get; set; }
        public DateTime? SysCreatedTime { get; set; }
        public string? SysCreatedBy { get; set; }
        public DateTime? SysModifiedTime { get; set; }
        public string? SysModifiedBy { get; set; }
        public string? SysCreatedHost { get; set; }
        public string? SysModifiedHost { get; set; }
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
        public string? Country { get; set; }
    }
}
