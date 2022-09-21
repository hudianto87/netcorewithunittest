using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TcustomerSalesHistory
    {
        public long IdSalesHistory { get; set; }
        public long IdCustomer { get; set; }
        public int IdSales { get; set; }
        public string MarketingLevel { get; set; } = null!;
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; } = null!;

        public virtual Tcustomer IdCustomerNavigation { get; set; } = null!;
        public virtual Tagent IdSalesNavigation { get; set; } = null!;
        public virtual TmarketingLevel MarketingLevelNavigation { get; set; } = null!;
    }
}
