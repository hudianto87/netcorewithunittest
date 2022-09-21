using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TautoDebitMember
    {
        public long TautoDebitMemberId { get; set; }
        public long TautoDebitGroupId { get; set; }
        public long? IdsubAccount { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime? ExpiredDate { get; set; }
        public double Amount { get; set; }
        public string Idstatus { get; set; } = null!;
        public string AccountNoFrom { get; set; } = null!;
        public string AccountNameFrom { get; set; } = null!;
        public int IdbankBranchFrom { get; set; }
        public int IdaccountBankTypeFrom { get; set; }
        public int IdcurrencyFrom { get; set; }
        public string AccountNoTo { get; set; } = null!;
        public string AccountNameTo { get; set; } = null!;
        public int IdbankBranchTo { get; set; }
        public int IdaccountBankTypeTo { get; set; }
        public int IdcurrencyTo { get; set; }
        public string? Remarks { get; set; }
        public string SysCreatedBy { get; set; } = null!;
        public DateTime SysCreatedTime { get; set; }
        public string SysCreatedHost { get; set; } = null!;
        public string? SysModifiedBy { get; set; }
        public DateTime? SysModifiedTime { get; set; }
        public string? SysModifiedHost { get; set; }
        public long? Idproduct { get; set; }
        public long? Idcustomer { get; set; }
        public string? IndexHelper { get; set; }
        public double? Fee { get; set; }

        public virtual TrefAccountBankType IdaccountBankTypeFromNavigation { get; set; } = null!;
        public virtual TrefAccountBankType IdaccountBankTypeToNavigation { get; set; } = null!;
        public virtual TrefBankBranch IdbankBranchFromNavigation { get; set; } = null!;
        public virtual TrefBankBranch IdbankBranchToNavigation { get; set; } = null!;
        public virtual TrefCurrency IdcurrencyFromNavigation { get; set; } = null!;
        public virtual TrefCurrency IdcurrencyToNavigation { get; set; } = null!;
        public virtual Tcustomer? IdcustomerNavigation { get; set; }
        public virtual Tproduct? IdproductNavigation { get; set; }
        public virtual TrefStatus IdstatusNavigation { get; set; } = null!;
        public virtual TsubAccount? IdsubAccountNavigation { get; set; }
        public virtual TautoDebitGroup TautoDebitGroup { get; set; } = null!;
    }
}
