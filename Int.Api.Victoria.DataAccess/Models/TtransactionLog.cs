using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TtransactionLog
    {
        public string? LogUser { get; set; }
        public string? LogType { get; set; }
        public DateTime? LogTimeStamp { get; set; }
        public string? Idcategory { get; set; }
        public string Idtransaction { get; set; } = null!;
        public string? ReferenceNo { get; set; }
        public string UnitHolderIdno { get; set; } = null!;
        public string? ProductCode { get; set; }
        public DateTime TransactionDate { get; set; }
        public string CodeAgent { get; set; } = null!;
        public string CodeBroker { get; set; } = null!;
        public double? SaldoProduct { get; set; }
        public DateTime? Navdate { get; set; }
        public double? Navvalue { get; set; }
        public DateTime? SettDate { get; set; }
        public double? Amount { get; set; }
        public double? Units { get; set; }
        public double? Percentage { get; set; }
        public double? Fee { get; set; }
        public double? FeeAmount { get; set; }
        public double? Charges { get; set; }
        public double? NetAmount { get; set; }
        public string? IdbankProduct { get; set; }
        public string? AccountNoProduct { get; set; }
        public string? IdbankCustomer { get; set; }
        public string? AccountNoCustomer { get; set; }
        public DateTime? EntryDate { get; set; }
        public string? EntryUser { get; set; }
        public DateTime? ProcessDate { get; set; }
        public string? ProcessUser { get; set; }
        public DateTime? EditDate { get; set; }
        public string? EditUser { get; set; }
        public DateTime? ApproveDate { get; set; }
        public string? ApproveUser { get; set; }
        public double? ApproveAmount { get; set; }
        public double? ApproveUnits { get; set; }
        public double? CustAmount { get; set; }
        public double? CustUnits { get; set; }
        public string? Sources { get; set; }
        public string? SourceBank { get; set; }
        public DateTime? SourcesDate { get; set; }
        public string? SourcesUser { get; set; }
        public string? Idstatus { get; set; }
        public string? PaymentMethod { get; set; }
        public string? Remark { get; set; }
        public bool? IsEntryBankAccount { get; set; }
        public double? Rebate { get; set; }
        public int? IdBatch { get; set; }
        public string? IdtransactionOld { get; set; }
        public string? CodeAgentOld { get; set; }
        public string? CodeBrokerOld { get; set; }
        public string? FundManagerCode { get; set; }
        public string? TxType { get; set; }
        public string? FwPrefix { get; set; }
        public DateTime? FwTimeStamp { get; set; }
    }
}
