using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TtransactionTemp
    {
        public string? Idcategory { get; set; }
        public string Idtransaction { get; set; } = null!;
        public string? ReferenceNo { get; set; }
        public string UnitHolderIdno { get; set; } = null!;
        public string? ProductCode { get; set; }
        public DateTime TransactionDate { get; set; }
        public string? CodeAgent { get; set; }
        public string? CodeBroker { get; set; }
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
        public string? IdtransactionOld { get; set; }
        public string? CodeAgentOld { get; set; }
        public string? CodeBrokerOld { get; set; }
        public string? FundManagerCode { get; set; }
        public string? TransIdOs { get; set; }
        public int? IdBatch { get; set; }
        public string? TxType { get; set; }
        public byte? CalcBy { get; set; }
        public double? OldAvgUnitCost { get; set; }
        public double? NewAvgUnitCost { get; set; }
        public string? FwPrefix { get; set; }
        public DateTime? FwTimeStamp { get; set; }
        public bool? IsSwitching { get; set; }
        public string? SwitchIdtransaction { get; set; }
        public double? OldOutstandingUnits { get; set; }
        public double? NewOutstandingUnits { get; set; }
        public double? SharingFee { get; set; }
        public double? SharingFeeTotal { get; set; }
    }
}
