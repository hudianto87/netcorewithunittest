using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TproductHistory
    {
        public int Idproduct { get; set; }
        public string ProductCode { get; set; } = null!;
        public string ProductName { get; set; } = null!;
        public string? Idcategory { get; set; }
        public string? IdbankCustody { get; set; }
        public string? Idcurrency { get; set; }
        public double? Charges { get; set; }
        public double? InitialUnit { get; set; }
        public double? TotalUnit { get; set; }
        public string? Idmftype { get; set; }
        public long? MaxCust { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public double? SubsAwal { get; set; }
        public double? SubsAdd { get; set; }
        public double? MaxHold { get; set; }
        public double? MaxHoldAmount { get; set; }
        public double? RedMin { get; set; }
        public double? MaxDaily { get; set; }
        public short? RedSettle { get; set; }
        public bool? MinUnit { get; set; }
        public double? MinUnitValue { get; set; }
        public string? Idstatus { get; set; }
        public DateTime? StatusChangeDate { get; set; }
        public string? StatusChangeBy { get; set; }
        public string? DividendType { get; set; }
        public string? ExternalCode1 { get; set; }
        public string? ExternalCode2 { get; set; }
        public string? RelationalCode { get; set; }
        public string? Isincode { get; set; }
        public string? MgtFeeCalcMethod { get; set; }
        public double? Pph23 { get; set; }
        public string? LogUser { get; set; }
        public DateTime? LogDate { get; set; }
    }
}
