using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TrefAccountBankType
    {
        public TrefAccountBankType()
        {
            TagentBankAccounts = new HashSet<TagentBankAccount>();
            TautoDebitMemberIdaccountBankTypeFromNavigations = new HashSet<TautoDebitMember>();
            TautoDebitMemberIdaccountBankTypeToNavigations = new HashSet<TautoDebitMember>();
            TcustBankAccounts = new HashSet<TcustBankAccount>();
            TproductBankAccounts = new HashSet<TproductBankAccount>();
        }

        public int IdaccountBankType { get; set; }
        public string? AccountBankTypeCode { get; set; }
        public string AccountBankType { get; set; } = null!;

        public virtual ICollection<TagentBankAccount> TagentBankAccounts { get; set; }
        public virtual ICollection<TautoDebitMember> TautoDebitMemberIdaccountBankTypeFromNavigations { get; set; }
        public virtual ICollection<TautoDebitMember> TautoDebitMemberIdaccountBankTypeToNavigations { get; set; }
        public virtual ICollection<TcustBankAccount> TcustBankAccounts { get; set; }
        public virtual ICollection<TproductBankAccount> TproductBankAccounts { get; set; }
    }
}
