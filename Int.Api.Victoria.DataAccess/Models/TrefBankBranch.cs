using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TrefBankBranch
    {
        public TrefBankBranch()
        {
            TagentBankAccounts = new HashSet<TagentBankAccount>();
            TautoDebitMemberIdbankBranchFromNavigations = new HashSet<TautoDebitMember>();
            TautoDebitMemberIdbankBranchToNavigations = new HashSet<TautoDebitMember>();
            TcustBankAccounts = new HashSet<TcustBankAccount>();
            TproductBankAccounts = new HashSet<TproductBankAccount>();
        }

        public int IdbankBranch { get; set; }
        public int Idbank { get; set; }
        public string? BranchCode { get; set; }
        public string BranchName { get; set; } = null!;
        public string? BranchCity { get; set; }
        public string? BranchFax { get; set; }
        public string? BranchStreet { get; set; }
        public string? BranchPhone { get; set; }
        public string? BranchZip { get; set; }
        public string? Bicode { get; set; }
        public string? ContactPerson { get; set; }
        public string SysCreatedBy { get; set; } = null!;
        public DateTime SysCreatedTime { get; set; }
        public string SysCreatedHost { get; set; } = null!;
        public string? SysModifiedBy { get; set; }
        public DateTime? SysModifiedTime { get; set; }
        public string? SysModifiedHost { get; set; }
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

        public virtual TrefBank IdbankNavigation { get; set; } = null!;
        public virtual ICollection<TagentBankAccount> TagentBankAccounts { get; set; }
        public virtual ICollection<TautoDebitMember> TautoDebitMemberIdbankBranchFromNavigations { get; set; }
        public virtual ICollection<TautoDebitMember> TautoDebitMemberIdbankBranchToNavigations { get; set; }
        public virtual ICollection<TcustBankAccount> TcustBankAccounts { get; set; }
        public virtual ICollection<TproductBankAccount> TproductBankAccounts { get; set; }
    }
}
