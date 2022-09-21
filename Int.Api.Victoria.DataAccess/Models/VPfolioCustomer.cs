using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class VPfolioCustomer
    {
        public string? Name { get; set; }
        public string Cif { get; set; } = null!;
        public DateTime? Dob { get; set; }
        public string? RiskClass { get; set; }
        public string SalesBranch { get; set; } = null!;
        public double? Asset { get; set; }
        public double? Liabilities { get; set; }
        public double? NetWorth { get; set; }
        public double? Income { get; set; }
        public double? Expense { get; set; }
        public double? Balance3 { get; set; }
        public double AmountMf { get; set; }
        public double AmountBond { get; set; }
    }
}
