using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TrefTransactionGenerator
    {
        public TrefTransactionGenerator()
        {
            TproductRegInvestmentPlans = new HashSet<TproductRegInvestmentPlan>();
            Ttransactions = new HashSet<Ttransaction>();
        }

        public short GeneratorId { get; set; }
        public string GeneratorCode { get; set; } = null!;
        public string GeneratorDescription { get; set; } = null!;

        public virtual ICollection<TproductRegInvestmentPlan> TproductRegInvestmentPlans { get; set; }
        public virtual ICollection<Ttransaction> Ttransactions { get; set; }
    }
}
