using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class VBancassTransaction
    {
        public long IdbancAssuranceTransaction { get; set; }
        public string? PolisNo { get; set; }
        public string? AccountNo { get; set; }
        public string? CurrencyCode { get; set; }
        public double? Amount { get; set; }
        public DateTime? SettlementDate { get; set; }
        public string? ReferenceNo { get; set; }
        public double? PaymentNo { get; set; }
        public byte? SysApprovalStatus { get; set; }
        public string? SysActionType { get; set; }
    }
}
