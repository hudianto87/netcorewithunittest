using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TgenuipendTagentProduct
    {
        public long TagentProductId { get; set; }
        public int? AgentId { get; set; }
        public long? Idproduct { get; set; }
        public string? IdreportType { get; set; }
        public string? Remarks { get; set; }
        public short? RedSettle { get; set; }
        public string? FromAcctName { get; set; }
        public string? FromAcctNo { get; set; }
        public string? ToAcctName { get; set; }
        public string? ToAcctNo { get; set; }
        public long? MfeeName { get; set; }
        public double? MfeeCharges { get; set; }
        public long? SubsFeeName { get; set; }
        public string? SubsTxFeeNett { get; set; }
        public double? SubsFeeCharges { get; set; }
        public string? SubsTxChargesNett { get; set; }
        public long? RedFeeName { get; set; }
        public string? RedTxFeeNett { get; set; }
        public double? RedFeeCharges { get; set; }
        public string? RedTxChargesNett { get; set; }
        public long? SwitchOutFeeName { get; set; }
        public string? SwitchOutTxFeeNett { get; set; }
        public double? SwitchOutFeeCharges { get; set; }
        public string? SwitchOutTxChargesNett { get; set; }
        public long? SwithcInFeeName { get; set; }
        public int? SellAgentFeeName { get; set; }
        public double? SellAgentFeeCharges { get; set; }
        public long? OtherFeeName { get; set; }
        public double? OtherCharges { get; set; }
        public int? PromotorFeeName { get; set; }
        public long? PromotorCharges { get; set; }
        public string? FromBank { get; set; }
        public int? FromBranch { get; set; }
        public string? FromAccType { get; set; }
        public string? FromCurr { get; set; }
        public string? ToBank { get; set; }
        public int? ToBranch { get; set; }
        public string? ToAccType { get; set; }
        public string? ToCurr { get; set; }
        public bool? FlagMfee { get; set; }
        public bool? FlagOfee { get; set; }
        public bool? FlagSfee { get; set; }
        public bool? FlagSellAgentFee { get; set; }
        public bool? FlagPromotorFee { get; set; }
        public bool? FlagMfee1 { get; set; }
        public bool? FlagSfee1 { get; set; }
        public string? SysCreatedBy { get; set; }
        public DateTime? SysCreatedTime { get; set; }
        public string? SysCreatedHost { get; set; }
        public string? SysModifiedBy { get; set; }
        public DateTime? SysModifiedTime { get; set; }
        public string? SysModifiedHost { get; set; }
        public string? SysActionType { get; set; }
        public byte? SysApprovalStatus { get; set; }
        public bool? SysRecStatus { get; set; }
        public string? SysPendingBy { get; set; }
        public DateTime? SysPendingTime { get; set; }
        public string? SysPendingHost { get; set; }
        public string? SysApprovalNotes { get; set; }
        public string? SysApprovedBy { get; set; }
        public DateTime? SysApprovedTime { get; set; }
        public string? SysApprovedHost { get; set; }
        public string? SysDeletedBy { get; set; }
        public DateTime? SysDeletedTime { get; set; }
        public string? SysDeletedHost { get; set; }
        public DateTime? EffectiveDate { get; set; }
    }
}
