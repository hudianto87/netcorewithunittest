using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class VTagentCustomerMovement
    {
        public long? IdvTagentCustomerMovement { get; set; }
        public long? IdagentCustomer { get; set; }
        public long Idcustomer { get; set; }
        public string? FullName { get; set; }
        public string UnitHolderIdno { get; set; } = null!;
        public DateTime? EffDate { get; set; }
        public int? AgentId { get; set; }
        public string? AgentTreeCode { get; set; }
        public string? NameAgent { get; set; }
        public string? CustomerStatus { get; set; }
        public string CustomerEmail { get; set; } = null!;
        public long? CustomerStructureId { get; set; }
        public long? AgentStructureId { get; set; }
        public string? SysCreatedBy { get; set; }
        public DateTime? SysModifiedTime { get; set; }
        public string? SysCreatedHost { get; set; }
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
