using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TbancAssuranceRider
    {
        public TbancAssuranceRider()
        {
            TbancAssuranceProductRiders = new HashSet<TbancAssuranceProductRider>();
            TbancAssuranceRiderPremis = new HashSet<TbancAssuranceRiderPremi>();
            TbancAssuranceSpajriders = new HashSet<TbancAssuranceSpajrider>();
        }

        public long IdbancAssuranceRider { get; set; }
        public string? RiderCode { get; set; }
        public string? RiderName { get; set; }
        public string SysCreatedBy { get; set; } = null!;
        public DateTime? SysCreatedTime { get; set; }
        public string SysCreatedHost { get; set; } = null!;
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

        public virtual ICollection<TbancAssuranceProductRider> TbancAssuranceProductRiders { get; set; }
        public virtual ICollection<TbancAssuranceRiderPremi> TbancAssuranceRiderPremis { get; set; }
        public virtual ICollection<TbancAssuranceSpajrider> TbancAssuranceSpajriders { get; set; }
    }
}
