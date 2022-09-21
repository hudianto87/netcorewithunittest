using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TresultFeeTiering
    {
        public int Id { get; set; }
        public string IdtransactionRed { get; set; } = null!;
        public string IdtransactionSub { get; set; } = null!;
        public string ProductCode { get; set; } = null!;
        public double Fee { get; set; }
        public double Unit { get; set; }
        public double NavValue { get; set; }
        public string Method { get; set; } = null!;
    }
}
