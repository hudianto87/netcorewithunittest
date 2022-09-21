using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TsubAccount
    {
        public TsubAccount()
        {
            TassetTransfers = new HashSet<TassetTransfer>();
            TautoDebitMembers = new HashSet<TautoDebitMember>();
            TautoSubRegisters = new HashSet<TautoSubRegister>();
            TcustomerRegInvestmentPlans = new HashSet<TcustomerRegInvestmentPlan>();
            TholdUnits = new HashSet<TholdUnit>();
            ToutStandingHistoryFifos = new HashSet<ToutStandingHistoryFifo>();
            Ttransactions = new HashSet<Ttransaction>();
        }

        public long IdsubAccount { get; set; }
        public long Idcustomer { get; set; }
        public long Idproduct { get; set; }
        public string NoAccount { get; set; } = null!;
        public byte SubAccountType { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime CreatedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Tcustomer IdcustomerNavigation { get; set; } = null!;
        public virtual Tproduct IdproductNavigation { get; set; } = null!;
        public virtual ICollection<TassetTransfer> TassetTransfers { get; set; }
        public virtual ICollection<TautoDebitMember> TautoDebitMembers { get; set; }
        public virtual ICollection<TautoSubRegister> TautoSubRegisters { get; set; }
        public virtual ICollection<TcustomerRegInvestmentPlan> TcustomerRegInvestmentPlans { get; set; }
        public virtual ICollection<TholdUnit> TholdUnits { get; set; }
        public virtual ICollection<ToutStandingHistoryFifo> ToutStandingHistoryFifos { get; set; }
        public virtual ICollection<Ttransaction> Ttransactions { get; set; }
    }
}
