using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TprodDistributorSale
    {
        public int DistributorSalesId { get; set; }
        public int? DistributorId { get; set; }
        public int? ProductId { get; set; }
        public DateTime? LastUpdate { get; set; }
        public double? Sales { get; set; }
    }
}
