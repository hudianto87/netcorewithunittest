using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TtransactionRiskProfileSimulation
    {
        public long Idtransaction { get; set; }
        public long Idcustomer { get; set; }
        public long Idproduct { get; set; }
        public string ProductType { get; set; } = null!;
        public string Idcategory { get; set; } = null!;
        public long? IdproductTo { get; set; }
        public DateTime SimulationDate { get; set; }
        public double BalanceIdr { get; set; }
    }
}
