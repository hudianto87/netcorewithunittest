using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TgroupProductList
    {
        public string GroupProduct { get; set; } = null!;
        public string ProductCode { get; set; } = null!;
        public bool? IsEnabled { get; set; }

        public virtual TgroupProduct GroupProductNavigation { get; set; } = null!;
    }
}
