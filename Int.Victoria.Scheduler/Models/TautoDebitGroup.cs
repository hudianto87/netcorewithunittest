using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TautoDebitGroup
    {
        public TautoDebitGroup()
        {
            TautoDebitMembers = new HashSet<TautoDebitMember>();
        }

        public long TautoDebitGroupId { get; set; }
        public string GroupName { get; set; } = null!;
        public byte AutoDebitDay { get; set; }
        public string FeeMethod { get; set; } = null!;
        public double FeeAmount { get; set; }
        public string Idstatus { get; set; } = null!;
        public int Idbank { get; set; }
        public bool IsFreeOfRedeemFee { get; set; }
        public string? Remarks { get; set; }
        public string SysCreatedBy { get; set; } = null!;
        public DateTime SysCreatedTime { get; set; }
        public string SysCreatedHost { get; set; } = null!;
        public string? SysModifiedBy { get; set; }
        public DateTime? SysModifiedTime { get; set; }
        public string? SysModifiedHost { get; set; }

        public virtual TrefBank IdbankNavigation { get; set; } = null!;
        public virtual TrefStatus IdstatusNavigation { get; set; } = null!;
        public virtual ICollection<TautoDebitMember> TautoDebitMembers { get; set; }
    }
}
