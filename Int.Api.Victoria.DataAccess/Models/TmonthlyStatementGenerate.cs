using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TmonthlyStatementGenerate
    {
        public int NoUrut { get; set; }
        public string? UnitHolderIdNo { get; set; }
        public string? FullName { get; set; }
        public string? HomeAddress { get; set; }
        public string? HomeCity { get; set; }
        public string? HomeZip { get; set; }
        public string? HomeCountry { get; set; }
        public DateTime? TanggalAwal { get; set; }
        public string? ProductName { get; set; }
        public string? TransType { get; set; }
        public string? IdCurrency { get; set; }
        public double? NavValue { get; set; }
        public double? Unit { get; set; }
        public double? Amount { get; set; }
        public int? NavPrecision { get; set; }
        public int? AmountPrecision { get; set; }
        public int? DividendPrecision { get; set; }
        public int? UnitPrecision { get; set; }
    }
}
