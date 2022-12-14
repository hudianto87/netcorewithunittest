using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TgenuipendTagentCustomer
    {
        public long? IdagentCustomer { get; set; }
        public DateTime? EffDate { get; set; }
        public string? AgentTreeCode { get; set; }
        public string? CustomerTreeCode { get; set; }
        public int? AgentId { get; set; }
        public long? Idcustomer { get; set; }
        public string? OldCodeAgent { get; set; }
        public bool? IsIncludeAum { get; set; }
        public byte? RecStatus { get; set; }
        public DateTime? RecCreated { get; set; }
        public string? RecCreator { get; set; }
        public DateTime? RecEdited { get; set; }
        public string? RecEditor { get; set; }
        public string? SysCreatedBy { get; set; }
        public DateTime? SysCreatedTime { get; set; }
        public string? SysCreatedHost { get; set; }
        public string? SysModifiedBy { get; set; }
        public DateTime? SysModifiedTime { get; set; }
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
    }
}
