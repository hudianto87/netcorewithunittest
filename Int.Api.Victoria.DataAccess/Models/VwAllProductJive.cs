using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class VwAllProductJive
    {
        public string? FmCode { get; set; }
        public string ProductCode { get; set; } = null!;
        public string? CustodyCode { get; set; }
        public string? Name { get; set; }
        public string? ShortName { get; set; }
        public string? FundType { get; set; }
        public string? Currency { get; set; }
        public string? ExternalCode1 { get; set; }
        public string? ExternalCode2 { get; set; }
        public string? ExternalCode3 { get; set; }
        public string? Rating { get; set; }
        public string? Remark1 { get; set; }
        public string? Remark2 { get; set; }
        public string? Remark3 { get; set; }
        public string? Code1 { get; set; }
        public string? Code2 { get; set; }
        public string? Code3 { get; set; }
        public string? Code4 { get; set; }
        public string? RiskProfile { get; set; }
        public DateTime? LaunchDate { get; set; }
        public decimal? InitialNav { get; set; }
        public decimal? MaxUnits { get; set; }
        public decimal? MaxLimitPct { get; set; }
        public decimal? Quota { get; set; }
        public DateTime? CutOffTime { get; set; }
        public decimal? RedMaxLimitPct { get; set; }
        public string? InvestmentCategory { get; set; }
        public string? SettlementFeeAcc { get; set; }
        public string? SettlementSubsAcc { get; set; }
        public string? SettlementRedAcc { get; set; }
        public decimal? MaxSubsAyear { get; set; }
        public decimal? MaxRedsAyear { get; set; }
        public decimal? MaxSwitchAyear { get; set; }
        public string? UnitsRounding { get; set; }
        public string? AmountRounding { get; set; }
        public string? PriceRounding { get; set; }
        public string? UnitsDecimal { get; set; }
        public string? AmountDecimal { get; set; }
        public string? PriceDecimal { get; set; }
        public string? AumBf { get; set; }
        public string? AumSubs { get; set; }
        public string? AumRed { get; set; }
        public string? AumSwisubs { get; set; }
        public string? AumSwired { get; set; }
        public string? AumDiv { get; set; }
        public string? AumAcr { get; set; }
        public string? SettlementPeriode { get; set; }
        public string ProductCategory { get; set; } = null!;
        public string ProductCategoryKey { get; set; } = null!;
        public DateTime? ProcessedDate { get; set; }
        public string? BatchFileRedFee { get; set; }
    }
}
