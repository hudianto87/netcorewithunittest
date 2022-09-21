using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TgoodFund
    {
        public int IdGoodFund { get; set; }
        public string ProductCode { get; set; } = null!;
        public DateTime Navdate { get; set; }
        public string? UnitHolderIdNo { get; set; }
        public string? CustomerName { get; set; }
        public double? Amount { get; set; }
        public string? ResourceBank { get; set; }
        public string? Remarks { get; set; }
        public string? ReferenceNo { get; set; }
        public string? IdTransaction { get; set; }
    }
}
