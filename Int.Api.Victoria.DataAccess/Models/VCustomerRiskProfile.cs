using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class VCustomerRiskProfile
    {
        public long Id { get; set; }
        public long CustomerId { get; set; }
        public string UnitHolderIdno { get; set; } = null!;
        public string? CustomerName { get; set; }
        public int? ProfileId { get; set; }
        public string? ProfileName { get; set; }
        public DateTime EffectiveDate { get; set; }
        public DateTime ExpiredDate { get; set; }
        public string? DisplayEffectiveDate { get; set; }
        public string? DisplayExpiredDate { get; set; }
    }
}
