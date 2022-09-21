using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TbancAssuranceAgent
    {
        public TbancAssuranceAgent()
        {
            TbancAssuranceCustomers = new HashSet<TbancAssuranceCustomer>();
        }

        public long IdbancAssuranceAgent { get; set; }
        public string? CodeAgentBranch { get; set; }
        public string? AgentCode { get; set; }
        public string? AgentName { get; set; }
        public string? BranchCode { get; set; }
        public string? BranchName { get; set; }
        public long? Idsex { get; set; }
        public long? IdmaritalStatus { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? WaperdNo { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? Fax { get; set; }
        public string? Email { get; set; }
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
        public string? Aajino { get; set; }

        public virtual ICollection<TbancAssuranceCustomer> TbancAssuranceCustomers { get; set; }
    }
}
