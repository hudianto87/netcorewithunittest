using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class VUigenTcustomerRegInvestmentPlanList
    {
        public long TcustomerRegInvestmentPlanId { get; set; }
        public long? TregularInvestmentPlanId { get; set; }
        public string? ReferenceNo { get; set; }
        public long? Idproduct { get; set; }
        public long? Idcustomer { get; set; }
        public long? Idsales { get; set; }
        public string? CustAccountNo { get; set; }
        public int? Tenor { get; set; }
        public double? Amount { get; set; }
        public double? Fee { get; set; }
        public double? FeeTax { get; set; }
        public double? FeeAmount { get; set; }
        public double? NetAmount { get; set; }
        public string? FeeMethod { get; set; }
        public string? AdjustFeeType { get; set; }
        public DateTime? RegDate { get; set; }
        public string? SysActionType { get; set; }
        public byte? SysApprovalStatus { get; set; }
        public bool? SysRecStatus { get; set; }
        public string? Customer { get; set; }
        public string? AccountNumber { get; set; }
        public string? SalesName { get; set; }
    }
}
