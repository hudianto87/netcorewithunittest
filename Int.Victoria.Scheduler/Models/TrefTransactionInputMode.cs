using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TrefTransactionInputMode
    {
        public TrefTransactionInputMode()
        {
            Ttransactions = new HashSet<Ttransaction>();
        }

        public byte InputModeId { get; set; }
        public string Description { get; set; } = null!;

        public virtual ICollection<Ttransaction> Ttransactions { get; set; }
    }
}
