using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TproductEmail
    {
        public int IdproductEmail { get; set; }
        public long Idproduct { get; set; }
        public string Email { get; set; } = null!;
        public byte IsDefault { get; set; }

        public virtual Tproduct IdproductNavigation { get; set; } = null!;
    }
}
