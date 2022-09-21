using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TrefCurrency
    {
        public TrefCurrency()
        {
            TagentBankAccounts = new HashSet<TagentBankAccount>();
            TautoDebitMemberIdcurrencyFromNavigations = new HashSet<TautoDebitMember>();
            TautoDebitMemberIdcurrencyToNavigations = new HashSet<TautoDebitMember>();
            TcustBankAccounts = new HashSet<TcustBankAccount>();
            TexchangeRateByProductCcurrencies = new HashSet<TexchangeRateByProduct>();
            TexchangeRateByProductTcurrencies = new HashSet<TexchangeRateByProduct>();
            TexchangeRateCcurrencies = new HashSet<TexchangeRate>();
            TexchangeRateTcurrencies = new HashSet<TexchangeRate>();
            TholidayGenerals = new HashSet<TholidayGeneral>();
            Tholidays = new HashSet<Tholiday>();
            Tkurs = new HashSet<Tkur>();
            TkursGenerals = new HashSet<TkursGeneral>();
            TproductBankAccounts = new HashSet<TproductBankAccount>();
            Tproducts = new HashSet<Tproduct>();
            TsharingFees = new HashSet<TsharingFee>();
        }

        public int Idcurrency { get; set; }
        public string CurrencyCode { get; set; } = null!;
        public string FullName { get; set; } = null!;
        public short? DecimalPrecision { get; set; }
        public int? RecOrder { get; set; }
        public DateTime SysCreatedTime { get; set; }
        public string SysCreatedBy { get; set; } = null!;
        public string SysCreatedHost { get; set; } = null!;
        public DateTime? SysModifiedTime { get; set; }
        public string? SysModifiedBy { get; set; }
        public string? SysModifiedHost { get; set; }
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

        public virtual ICollection<TagentBankAccount> TagentBankAccounts { get; set; }
        public virtual ICollection<TautoDebitMember> TautoDebitMemberIdcurrencyFromNavigations { get; set; }
        public virtual ICollection<TautoDebitMember> TautoDebitMemberIdcurrencyToNavigations { get; set; }
        public virtual ICollection<TcustBankAccount> TcustBankAccounts { get; set; }
        public virtual ICollection<TexchangeRateByProduct> TexchangeRateByProductCcurrencies { get; set; }
        public virtual ICollection<TexchangeRateByProduct> TexchangeRateByProductTcurrencies { get; set; }
        public virtual ICollection<TexchangeRate> TexchangeRateCcurrencies { get; set; }
        public virtual ICollection<TexchangeRate> TexchangeRateTcurrencies { get; set; }
        public virtual ICollection<TholidayGeneral> TholidayGenerals { get; set; }
        public virtual ICollection<Tholiday> Tholidays { get; set; }
        public virtual ICollection<Tkur> Tkurs { get; set; }
        public virtual ICollection<TkursGeneral> TkursGenerals { get; set; }
        public virtual ICollection<TproductBankAccount> TproductBankAccounts { get; set; }
        public virtual ICollection<Tproduct> Tproducts { get; set; }
        public virtual ICollection<TsharingFee> TsharingFees { get; set; }
    }
}
