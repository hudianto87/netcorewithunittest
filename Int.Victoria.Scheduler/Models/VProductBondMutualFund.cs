using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class VProductBondMutualFund
    {
        public long? ViewId { get; set; }
        public long TproductId { get; set; }
        public int FhId { get; set; }
        public string ProductCode { get; set; } = null!;
        public string ProductName { get; set; } = null!;
        public string? Idcategory { get; set; }
        public long IdbankCustody { get; set; }
        public int? Idcurrency { get; set; }
        public string? Idstatus { get; set; }
        public string? ExternalCode1 { get; set; }
        public string? Isincode { get; set; }
        public byte NavPrecision { get; set; }
        public byte AmountPrecision { get; set; }
        public string? RoundMethodAmount { get; set; }
        public string? RoundMethodUnit { get; set; }
        public string ProdCategory { get; set; } = null!;
        public int? ProfileId { get; set; }
        public string? ProfileName { get; set; }
    }
}
