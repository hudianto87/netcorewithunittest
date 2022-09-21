using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TredemptionFifo
    {
        public long Id { get; set; }
        public long IdtransactionRed { get; set; }
        public long IdtransactionSub { get; set; }
        public DateTime SubscriptionDate { get; set; }
        public DateTime RedemptionDate { get; set; }
        public double AllocationUnits { get; set; }
        public double OutstandingUnits { get; set; }
        public double SubscriptionUnits { get; set; }
        public double Fee { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; } = null!;

        public virtual Ttransaction IdtransactionRedNavigation { get; set; } = null!;
        public virtual Ttransaction IdtransactionSubNavigation { get; set; } = null!;
    }
}
