using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class VhToutStandingHistoryFifo
    {
        public string UnitHolderIdno { get; set; } = null!;
        public string ProductCode { get; set; } = null!;
        public string NoAccount { get; set; } = null!;
        public long IdoutstandingHistory { get; set; }
        public long IdSubAccount { get; set; }
        public int? IdSales { get; set; }
        public DateTime OutstandingDate { get; set; }
        public long IdsubTransaction { get; set; }
        public double BalanceUnit { get; set; }
        public double NavValue { get; set; }
        public long? IdredTransaction { get; set; }
        public double? AvgNav { get; set; }
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime CreatedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
