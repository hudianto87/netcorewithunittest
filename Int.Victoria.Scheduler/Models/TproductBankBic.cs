using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TproductBankBic
    {
        public int Idbic { get; set; }
        public long Idproduct { get; set; }
        public int IdproductBankAccount { get; set; }

        public virtual TproductBankAccount IdproductBankAccountNavigation { get; set; } = null!;
        public virtual Tproduct IdproductNavigation { get; set; } = null!;
    }
}
