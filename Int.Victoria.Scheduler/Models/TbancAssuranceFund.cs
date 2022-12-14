using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TbancAssuranceFund
    {
        public TbancAssuranceFund()
        {
            TbancAssuranceFundBalances = new HashSet<TbancAssuranceFundBalance>();
            TbancAssuranceProductFunds = new HashSet<TbancAssuranceProductFund>();
            TbancAssuranceSpajfunds = new HashSet<TbancAssuranceSpajfund>();
        }

        public long IdbancAssuranceFund { get; set; }
        public string FundCode { get; set; } = null!;
        public string FundName { get; set; } = null!;
        public string SysCreatedBy { get; set; } = null!;
        public DateTime? SysCreatedTime { get; set; }
        public string? SysCreatedHost { get; set; }
        public string? SysModifiedBy { get; set; }
        public DateTime? SysModifiedTime { get; set; }
        public string? SysModifiedHost { get; set; }
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
        public string SysActionType { get; set; } = null!;
        public byte SysApprovalStatus { get; set; }
        public bool SysRecStatus { get; set; }
        public string? FundType { get; set; }
        public long? FundCurrency { get; set; }
        public int? FundProportion { get; set; }

        public virtual ICollection<TbancAssuranceFundBalance> TbancAssuranceFundBalances { get; set; }
        public virtual ICollection<TbancAssuranceProductFund> TbancAssuranceProductFunds { get; set; }
        public virtual ICollection<TbancAssuranceSpajfund> TbancAssuranceSpajfunds { get; set; }
    }
}
