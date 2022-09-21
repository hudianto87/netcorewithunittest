using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TrefPaymentMethod
    {
        public string Methode { get; set; } = null!;
        public string PaymentMethod { get; set; } = null!;
        public bool? IsMain { get; set; }
    }
}
