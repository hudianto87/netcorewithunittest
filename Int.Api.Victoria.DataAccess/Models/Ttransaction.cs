using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class Ttransaction
    {
        public Ttransaction()
        {
            InverseSourceIdtransactionNavigation = new HashSet<Ttransaction>();
            ToutStandingHistoryFifoIdredTransactionNavigations = new HashSet<ToutStandingHistoryFifo>();
            ToutStandingHistoryFifoIdsubTransactionNavigations = new HashSet<ToutStandingHistoryFifo>();
            TredemptionFifoIdtransactionRedNavigations = new HashSet<TredemptionFifo>();
            TredemptionFifoIdtransactionSubNavigations = new HashSet<TredemptionFifo>();
            TtransactionBankAccounts = new HashSet<TtransactionBankAccount>();
            TtransactionJournals = new HashSet<TtransactionJournal>();
            TtransactionNotifications = new HashSet<TtransactionNotification>();
        }

        public long Idtransaction { get; set; }
        public string Idcategory { get; set; } = null!;
        public string Idstatus { get; set; } = null!;
        public string? ReferenceNo { get; set; }
        public long? IdsubAccount { get; set; }
        public long Idcustomer { get; set; }
        public long Idproduct { get; set; }
        public int Idsales { get; set; }
        public string? AgentTreeCode { get; set; }
        public int? Idbranch { get; set; }
        public string? BranchTreeCode { get; set; }
        public DateTime? TransactionDate { get; set; }
        public DateTime? Navdate { get; set; }
        public DateTime? SettDate { get; set; }
        public DateTime? BookingDate { get; set; }
        public double? Navvalue { get; set; }
        public string? SubscriptionFeeMethod { get; set; }
        public double? Amount { get; set; }
        public double? NetAmount { get; set; }
        public double? Units { get; set; }
        public double? Percentage { get; set; }
        public double? Fee { get; set; }
        public double? FeeAmount { get; set; }
        public double? FeeUnit { get; set; }
        public double? Charges { get; set; }
        public byte InputMode { get; set; }
        public double? RedemptionValue { get; set; }
        public bool IsRedemAll { get; set; }
        public string? DividendMode { get; set; }
        public string? AccountNoCustomer { get; set; }
        public double? ApproveAmount { get; set; }
        public double? ApproveUnits { get; set; }
        public double? CustAmount { get; set; }
        public double? CustUnits { get; set; }
        public long? SourceIdtransaction { get; set; }
        public string? PaymentMethod { get; set; }
        public string? Remark { get; set; }
        public int? Idbatch { get; set; }
        public double? SwitchingPercent { get; set; }
        public double? NewOutstandingUnits { get; set; }
        public double? IntRate { get; set; }
        public string? IncInterestAro { get; set; }
        public DateTime? MaturityDate { get; set; }
        public int? Term { get; set; }
        public bool? IsWaiver { get; set; }
        public string? RedAdjustFeeType { get; set; }
        public int? CustomerProfileId { get; set; }
        public int? ProductProfileId { get; set; }
        public string? BatchUser { get; set; }
        public DateTime? BatchDate { get; set; }
        public DateTime EntryDate { get; set; }
        public string EntryUser { get; set; } = null!;
        public DateTime? EditDate { get; set; }
        public string? EditUser { get; set; }
        public DateTime? ApproveDate { get; set; }
        public string? ApproveUser { get; set; }
        public DateTime? UnapproveDate { get; set; }
        public string? UnapproveUser { get; set; }
        public DateTime? ProcessDate { get; set; }
        public string? ProcessUser { get; set; }
        public DateTime? ApproveBookingDate { get; set; }
        public string? ApproveBookingUser { get; set; }
        public bool IsBookingApproved { get; set; }
        public short GeneratorId { get; set; }
        public string? GeneratorData1 { get; set; }
        public string? GeneratorData2 { get; set; }
        public string? GeneratorData3 { get; set; }
        public long? IddividendSummary { get; set; }
        public bool? IsFreeOfRedeemFee { get; set; }
        public DateTime? GoodFundDate { get; set; }
        public string? GoodFundUser { get; set; }
        public DateTime? UnGoodFundDate { get; set; }
        public string? UnGoodFundUser { get; set; }
        public string? VerifyUser { get; set; }
        public DateTime? VerifyTime { get; set; }
        public string? UnVerifyUser { get; set; }
        public DateTime? UnVerifyTime { get; set; }
        public string? EntryHost { get; set; }
        public string? EditHost { get; set; }
        public string? ApproveHost { get; set; }
        public string? UnapproveHost { get; set; }
        public string? GoodFundHost { get; set; }
        public string? UnGoodHost { get; set; }
        public string? VerifyHost { get; set; }
        public string? UnVerifyHost { get; set; }
        public long? TproductTransactionFeeId { get; set; }
        public double? FeeTax { get; set; }
        public long? HoldId { get; set; }
        public string? GenerateStatus { get; set; }
        public string? SinvestRefNo { get; set; }

        public virtual TrefTransactionGenerator Generator { get; set; } = null!;
        public virtual Tagent? IdbranchNavigation { get; set; }
        public virtual Tcustomer IdcustomerNavigation { get; set; } = null!;
        public virtual TdividendSummary? IddividendSummaryNavigation { get; set; }
        public virtual Tproduct IdproductNavigation { get; set; } = null!;
        public virtual Tagent IdsalesNavigation { get; set; } = null!;
        public virtual TsubAccount? IdsubAccountNavigation { get; set; }
        public virtual TrefTransactionInputMode InputModeNavigation { get; set; } = null!;
        public virtual Ttransaction? SourceIdtransactionNavigation { get; set; }
        public virtual ICollection<Ttransaction> InverseSourceIdtransactionNavigation { get; set; }
        public virtual ICollection<ToutStandingHistoryFifo> ToutStandingHistoryFifoIdredTransactionNavigations { get; set; }
        public virtual ICollection<ToutStandingHistoryFifo> ToutStandingHistoryFifoIdsubTransactionNavigations { get; set; }
        public virtual ICollection<TredemptionFifo> TredemptionFifoIdtransactionRedNavigations { get; set; }
        public virtual ICollection<TredemptionFifo> TredemptionFifoIdtransactionSubNavigations { get; set; }
        public virtual ICollection<TtransactionBankAccount> TtransactionBankAccounts { get; set; }
        public virtual ICollection<TtransactionJournal> TtransactionJournals { get; set; }
        public virtual ICollection<TtransactionNotification> TtransactionNotifications { get; set; }
    }
}
