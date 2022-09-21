using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TrefStatus
    {
        public TrefStatus()
        {
            TautoDebitGroups = new HashSet<TautoDebitGroup>();
            TautoDebitMembers = new HashSet<TautoDebitMember>();
            Tblokirs = new HashSet<Tblokir>();
            TsharingFeeRules = new HashSet<TsharingFeeRule>();
            TsharingFees = new HashSet<TsharingFee>();
        }

        public string Idstatus { get; set; } = null!;
        public string StatusName { get; set; } = null!;

        public virtual ICollection<TautoDebitGroup> TautoDebitGroups { get; set; }
        public virtual ICollection<TautoDebitMember> TautoDebitMembers { get; set; }
        public virtual ICollection<Tblokir> Tblokirs { get; set; }
        public virtual ICollection<TsharingFeeRule> TsharingFeeRules { get; set; }
        public virtual ICollection<TsharingFee> TsharingFees { get; set; }
    }
}
