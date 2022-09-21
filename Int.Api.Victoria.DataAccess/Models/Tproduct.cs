using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class Tproduct
    {
        public Tproduct()
        {
            TagentProducts = new HashSet<TagentProduct>();
            TassetTransfers = new HashSet<TassetTransfer>();
            TautoDebitMembers = new HashSet<TautoDebitMember>();
            TautoSubRegisters = new HashSet<TautoSubRegister>();
            Tcpfquota = new HashSet<Tcpfquotum>();
            TcustomerRegInvestmentPlans = new HashSet<TcustomerRegInvestmentPlan>();
            TdistributedIncomeData = new HashSet<TdistributedIncomeDatum>();
            TdividendSummaries = new HashSet<TdividendSummary>();
            TendOfDays = new HashSet<TendOfDay>();
            TexchangeRateByProducts = new HashSet<TexchangeRateByProduct>();
            Tkurs = new HashSet<Tkur>();
            TnavTemps = new HashSet<TnavTemp>();
            Tnavs = new HashSet<Tnav>();
            TproductBankAccounts = new HashSet<TproductBankAccount>();
            TproductBankBics = new HashSet<TproductBankBic>();
            TproductBundlingDetails = new HashSet<TproductBundlingDetail>();
            TproductEmails = new HashSet<TproductEmail>();
            TproductExitWindows = new HashSet<TproductExitWindow>();
            TproductFeeByDates = new HashSet<TproductFeeByDate>();
            TproductFees = new HashSet<TproductFee>();
            TproductOfferingPeriods = new HashSet<TproductOfferingPeriod>();
            TproductRegInvestmentPlans = new HashSet<TproductRegInvestmentPlan>();
            TproductTransactionFees = new HashSet<TproductTransactionFee>();
            TsubAccounts = new HashSet<TsubAccount>();
            Ttransactions = new HashSet<Ttransaction>();
        }

        public long Idproduct { get; set; }
        public int? FhId { get; set; }
        public string ProductCode { get; set; } = null!;
        public string ProductName { get; set; } = null!;
        public string Idcategory { get; set; } = null!;
        public int IdbankCustody { get; set; }
        public int Idcurrency { get; set; }
        public double? Charges { get; set; }
        public double? InitialUnit { get; set; }
        public double? TotalUnit { get; set; }
        public string Idmftype { get; set; } = null!;
        public long? MaxCust { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public double? InitialNav { get; set; }
        public decimal? MaxUnits { get; set; }
        public double? PercentMax { get; set; }
        public decimal? Quota { get; set; }
        public double? MaxHold { get; set; }
        public double? MaxHoldAmount { get; set; }
        public double? MaxDaily { get; set; }
        public short SubSettle { get; set; }
        public short RedSettle { get; set; }
        public bool? MinUnit { get; set; }
        public double? MinUnitValue { get; set; }
        public bool Idstatus { get; set; }
        public string DividendType { get; set; } = null!;
        public string? ExternalCode1 { get; set; }
        public string? ExternalCode2 { get; set; }
        public string? RelationalCode { get; set; }
        public string? Isincode { get; set; }
        public string? MgtFeeCalcMethod { get; set; }
        public string? CustFeeCalcMethod { get; set; }
        public string? SellFeeCalcMethod { get; set; }
        public string? Glcode { get; set; }
        public string? AccStatementName { get; set; }
        public byte NavPrecision { get; set; }
        public bool? Pph23 { get; set; }
        public bool? IsUnitized { get; set; }
        public double? MaxTotDaily { get; set; }
        public string? MaxTotDailyOf { get; set; }
        public short? AumdateAdd { get; set; }
        public byte UnitPrecision { get; set; }
        public string RoundMethodAmount { get; set; } = null!;
        public string RoundMethodUnit { get; set; } = null!;
        public double SubsMin { get; set; }
        public double SubsAwalMax { get; set; }
        public double SubsTopUpMax { get; set; }
        public double RedMin { get; set; }
        public double? MaxRedUnitDailyPerCustomer { get; set; }
        public double MinBalanceAfterRedemption { get; set; }
        public double MinUnitSwitching { get; set; }
        public double? MaxUnitSwitching { get; set; }
        public double MinBalanceAfterSwitching { get; set; }
        public double LimitUnitAfterSwitching { get; set; }
        public bool AllowSwitching { get; set; }
        public bool AllowRedemption { get; set; }
        public bool AllowTopUp { get; set; }
        public bool AllowSubscription { get; set; }
        public string? CutOffTimeSubscription { get; set; }
        public string? CutOffTimeRedemption { get; set; }
        public string? CutOffTimeSwitching { get; set; }
        public string? CutOffTimeBatchOrder { get; set; }
        public byte AmountPrecision { get; set; }
        public int ClosedAccountDay { get; set; }
        public string NavredMethod { get; set; } = null!;
        public string? FundMgrCode { get; set; }
        public string? InitAgentCd { get; set; }
        public byte? DividendPrecision { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string? ApprovedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public string? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public int? IdproductType { get; set; }
        public string? CbestNo { get; set; }
        public string? Sidno { get; set; }
        public string? Scano { get; set; }
        public string? Micode { get; set; }
        public string? Bkcode { get; set; }
        public int? IdjenisProduct { get; set; }
        public double? MaxEquity { get; set; }
        public double? MaxFixedIncome { get; set; }
        public double? MaxMoney { get; set; }
        public double? MinEquity { get; set; }
        public double? MinFixedIncome { get; set; }
        public double? MinMoney { get; set; }
        public double? MaxOther { get; set; }
        public double? MinOther { get; set; }
        public string? MaxUnit { get; set; }
        public double? SubcriptionFee { get; set; }
        public double? RedemptionFee { get; set; }
        public double? SubcriptionMinNext { get; set; }
        public double? CustodianFee { get; set; }
        public double? ManagementFee { get; set; }
        public double? MaxRedemptionLimit { get; set; }
        public string? Npwp { get; set; }
        public DateTime? NpwpregisterDate { get; set; }
        public string? KikplaceEstablished { get; set; }
        public string? Kikarticle { get; set; }
        public DateTime? KikarticleDate { get; set; }
        public string? BapepamLkarticle { get; set; }
        public DateTime? BapepamLkarticleDate { get; set; }
        public string? Kctfile { get; set; }
        public bool? IsFoundation { get; set; }
        public int? ProfileId { get; set; }
        public string? CreatedHost { get; set; }
        public string? LastModifiedHost { get; set; }
        public string SysCreatedBy { get; set; } = null!;
        public DateTime SysCreatedTime { get; set; }
        public string SysCreatedHost { get; set; } = null!;
        public string? SysModifiedBy { get; set; }
        public DateTime? SysModifiedTime { get; set; }
        public string? SysModifiedHost { get; set; }
        public short SwtSettle { get; set; }
        public double? RedMinAmount { get; set; }
        public double? MinAmountSwitching { get; set; }
        public short RedMinMode { get; set; }
        public short MinSwitchingMode { get; set; }
        public int? AutoSubMinMonth { get; set; }
        public int? AutoSubMaxMonth { get; set; }
        public string SysActionType { get; set; } = null!;
        public byte SysApprovalStatus { get; set; }
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
        public string? SinvestFundCode { get; set; }
        public bool? IsSharia { get; set; }
        public string? RedFeePeriodUnit { get; set; }
        public bool? IsAutoEod { get; set; }
        public string? SubFeePeriodUnit { get; set; }
        public string? BuyFeeCalcMethod { get; set; }
        public string? DividentInvestment { get; set; }
        public bool? IsInstallment { get; set; }
        public bool? IsReguler { get; set; }
        public bool? IsPrivate { get; set; }
        public bool? IsPrefered { get; set; }
        public bool? SettleRedemptionToCore { get; set; }
        public int? TcouponFreqId { get; set; }
        public bool? IsOffShore { get; set; }
        public string? ProductCountry { get; set; }
        public decimal? MinimumFeeSubscription { get; set; }
        public decimal? MaximumFeeSubscription { get; set; }
        public decimal? MinimumRedemptionAmount { get; set; }
        public decimal? MinimumFeeRedemption { get; set; }
        public decimal? MaximumFeeRedemption { get; set; }
        public decimal? MinimumFeeSwitching { get; set; }
        public decimal? MaximumFeeSwitching { get; set; }

        public virtual TfundHouse? Fh { get; set; }
        public virtual TrefBankCustody IdbankCustodyNavigation { get; set; } = null!;
        public virtual TrefCurrency IdcurrencyNavigation { get; set; } = null!;
        public virtual TrefProfile? Profile { get; set; }
        public virtual TproductCustomer TproductCustomer { get; set; } = null!;
        public virtual ICollection<TagentProduct> TagentProducts { get; set; }
        public virtual ICollection<TassetTransfer> TassetTransfers { get; set; }
        public virtual ICollection<TautoDebitMember> TautoDebitMembers { get; set; }
        public virtual ICollection<TautoSubRegister> TautoSubRegisters { get; set; }
        public virtual ICollection<Tcpfquotum> Tcpfquota { get; set; }
        public virtual ICollection<TcustomerRegInvestmentPlan> TcustomerRegInvestmentPlans { get; set; }
        public virtual ICollection<TdistributedIncomeDatum> TdistributedIncomeData { get; set; }
        public virtual ICollection<TdividendSummary> TdividendSummaries { get; set; }
        public virtual ICollection<TendOfDay> TendOfDays { get; set; }
        public virtual ICollection<TexchangeRateByProduct> TexchangeRateByProducts { get; set; }
        public virtual ICollection<Tkur> Tkurs { get; set; }
        public virtual ICollection<TnavTemp> TnavTemps { get; set; }
        public virtual ICollection<Tnav> Tnavs { get; set; }
        public virtual ICollection<TproductBankAccount> TproductBankAccounts { get; set; }
        public virtual ICollection<TproductBankBic> TproductBankBics { get; set; }
        public virtual ICollection<TproductBundlingDetail> TproductBundlingDetails { get; set; }
        public virtual ICollection<TproductEmail> TproductEmails { get; set; }
        public virtual ICollection<TproductExitWindow> TproductExitWindows { get; set; }
        public virtual ICollection<TproductFeeByDate> TproductFeeByDates { get; set; }
        public virtual ICollection<TproductFee> TproductFees { get; set; }
        public virtual ICollection<TproductOfferingPeriod> TproductOfferingPeriods { get; set; }
        public virtual ICollection<TproductRegInvestmentPlan> TproductRegInvestmentPlans { get; set; }
        public virtual ICollection<TproductTransactionFee> TproductTransactionFees { get; set; }
        public virtual ICollection<TsubAccount> TsubAccounts { get; set; }
        public virtual ICollection<Ttransaction> Ttransactions { get; set; }
    }
}
