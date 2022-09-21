using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class VTransactionList
    {
        public long Idtransaction { get; set; }
        public string Idstatus { get; set; } = null!;
        public string Idcategory { get; set; } = null!;
        public string UnitHolderIdno { get; set; } = null!;
        public string? FullName { get; set; }
        public string ProductCode { get; set; } = null!;
        public string ProductName { get; set; } = null!;
        public string? SalesName { get; set; }
        public string SalesCode { get; set; } = null!;
        public DateTime? TransactionDate { get; set; }
        public DateTime? Navdate { get; set; }
        public DateTime? SettleDate { get; set; }
        public double? Nav { get; set; }
        public double? NetAmount { get; set; }
        public double? Amount { get; set; }
        public double? Fee { get; set; }
        public double? FeeAmount { get; set; }
        public double? Units { get; set; }
        public string? SubscriptionFeeMethod { get; set; }
        public string? PaymentMethod { get; set; }
        public DateTime EntryDate { get; set; }
        public string EntryUser { get; set; } = null!;
        public DateTime? EditDate { get; set; }
        public string? EditUser { get; set; }
        public string? ReferenceNo { get; set; }
        public string? Sid { get; set; }
        public double? Charges { get; set; }
        public long Idcustomer { get; set; }
        public long Idproduct { get; set; }
        public double? PercentNav { get; set; }
        public double? PercentRedemption { get; set; }
        public bool? IsWaiver { get; set; }
        public string SourceTransaction { get; set; } = null!;
        public string? Column1 { get; set; }
        public string? Column2 { get; set; }
        public string? Column3 { get; set; }
        public string? Column4 { get; set; }
        public string? Column5 { get; set; }
        public string? Column6 { get; set; }
        public string? Column7 { get; set; }
        public string? Column8 { get; set; }
        public string? Column9 { get; set; }
        public string? Column10 { get; set; }
    }
}
