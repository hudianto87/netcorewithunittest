using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class VRbsTtransaction
    {
        public long TtransactionId { get; set; }
        public int TrefCategoryId { get; set; }
        public string Idtransaction { get; set; } = null!;
        public long Idcustomer { get; set; }
        public long TproductId { get; set; }
        public string? Idstatus { get; set; }
        public string? CodeAgent { get; set; }
        public string? CodeBroker { get; set; }
        public long? Idsales { get; set; }
        public long? IdteamLeader { get; set; }
        public long? Idbranch { get; set; }
        public long? IdagentQuota { get; set; }
        public string? ReferenceNo { get; set; }
        public DateTime Navdate { get; set; }
        public DateTime TransactionDate { get; set; }
        public DateTime? SettDate { get; set; }
        public DateTime? MaturityDate { get; set; }
        public decimal Units { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal? Fee { get; set; }
        public decimal? FeeAmount { get; set; }
        public decimal? SettleAmount { get; set; }
        public decimal? Charges { get; set; }
        public string? IdbankProduct { get; set; }
        public string? AccountNoProduct { get; set; }
        public string? IdbankCustomer { get; set; }
        public string? AccountNoCustomer { get; set; }
        public string? PaymentMethod { get; set; }
        public string? Remark { get; set; }
        public string? Remark2 { get; set; }
        public string? Remark3 { get; set; }
        public bool? IsEntryBankAccount { get; set; }
        public string? FundManagerCode { get; set; }
        public string? FwPrefix { get; set; }
        public DateTime? FwTimeStamp { get; set; }
        public double? IntRate { get; set; }
        public string? Reject1Reason { get; set; }
        public string? Reject2Reason { get; set; }
        public string? Reject3Reason { get; set; }
        public int? Idbooking { get; set; }
        public bool? IsWaiver { get; set; }
        public bool? IsBackOffice { get; set; }
        public DateTime? BookedDate { get; set; }
        public double? AccrudInterestTaxPercentage { get; set; }
        public double? CapitalGainTaxPercentage { get; set; }
        public double? CapitalCost { get; set; }
        public double? TotalCost { get; set; }
        public double? CapitalGainTax { get; set; }
        public double? AccrudInterest { get; set; }
        public double? AccrudInterestTax { get; set; }
        public bool? IsAdjust { get; set; }
        public bool? IsMailed { get; set; }
        public string? SubRegistry { get; set; }
        public short? TrefSellMethodId { get; set; }
        public string? BatchUser { get; set; }
        public DateTime? BatchDate { get; set; }
        public long? HoldSeqId { get; set; }
        public string SysCreatedBy { get; set; } = null!;
        public DateTime SysCreatedTime { get; set; }
        public string SysCreatedHost { get; set; } = null!;
        public string? SysModifiedBy { get; set; }
        public DateTime? SysModifiedTime { get; set; }
        public string? SysModifiedHost { get; set; }
        public string? SysApprovedBy { get; set; }
        public DateTime? SysApprovedTime { get; set; }
        public string? SysApprovedHost { get; set; }
        public string? SysUnApprovedBy { get; set; }
        public DateTime? SysUnApprovedTime { get; set; }
        public string? SysUnApprovedHost { get; set; }
        public string? SysRejectedBy { get; set; }
        public DateTime? SysRejectedTime { get; set; }
        public string? SysRejectedHost { get; set; }
        public string? SysSettledBy { get; set; }
        public DateTime? SysSettledTime { get; set; }
        public string? SysSettledHost { get; set; }
        public long? SourceIdtransaction { get; set; }
        public long? TassetTransferId { get; set; }
        public double? Ytm { get; set; }
        public int? AccruedDays { get; set; }
        public int? HoldingPeriod { get; set; }
        public bool? IsNetting { get; set; }
        public decimal? OldUnits { get; set; }
        public short? GeneratorId { get; set; }
        public string? GeneratorData1 { get; set; }
        public string? SysVerifiedBy { get; set; }
        public DateTime? SysVerifiedTime { get; set; }
        public string? SysVerifiedHost { get; set; }
        public string? Ctpnumber { get; set; }
        public string? OpicsGenStatus { get; set; }
        public string? OpicsGenBy { get; set; }
        public DateTime? OpicsGenTime { get; set; }
        public string? OpicsGenHost { get; set; }
        public decimal? NettTax { get; set; }
        public double? OriginalIndicativePrice { get; set; }
        public double? CurrentIndicativePrice { get; set; }
        public string? MurexId { get; set; }
        public string? SendMurexStatus { get; set; }
        public string? SendMurexBy { get; set; }
        public DateTime? SendMurexDate { get; set; }
        public string? SendMurexHost { get; set; }
        public string? MurexDealNo { get; set; }
    }
}
