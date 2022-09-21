using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class Tkur
    {
        public int Idkurs { get; set; }
        public long Idproduct { get; set; }
        public int Idcurrency { get; set; }
        public DateTime CurrDate { get; set; }
        public double Value { get; set; }

        public virtual TrefCurrency IdcurrencyNavigation { get; set; } = null!;
        public virtual Tproduct IdproductNavigation { get; set; } = null!;
    }
}
