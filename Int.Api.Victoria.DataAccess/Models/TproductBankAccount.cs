using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TproductBankAccount
    {
        public TproductBankAccount()
        {
            TautoSubRegisters = new HashSet<TautoSubRegister>();
            TproductBankBics = new HashSet<TproductBankBic>();
        }

        public int IdproductBankAccount { get; set; }
        public long Idproduct { get; set; }
        public int? IdbankBranch { get; set; }
        public int? IdaccountBankType { get; set; }
        public int Idcurrency { get; set; }
        public string AccountNo { get; set; } = null!;
        public string AccountName { get; set; } = null!;
        public bool IsMandatory { get; set; }
        public string Idcategory { get; set; } = null!;
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string? LastModifiedBy { get; set; }
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
        public string? Sacode { get; set; }

        public virtual TrefAccountBankType? IdaccountBankTypeNavigation { get; set; }
        public virtual TrefBankBranch? IdbankBranchNavigation { get; set; }
        public virtual TrefCurrency IdcurrencyNavigation { get; set; } = null!;
        public virtual Tproduct IdproductNavigation { get; set; } = null!;
        public virtual ICollection<TautoSubRegister> TautoSubRegisters { get; set; }
        public virtual ICollection<TproductBankBic> TproductBankBics { get; set; }
    }
}
