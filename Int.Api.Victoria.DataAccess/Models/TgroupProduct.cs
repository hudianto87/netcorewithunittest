using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TgroupProduct
    {
        public TgroupProduct()
        {
            TgroupProductLists = new HashSet<TgroupProductList>();
        }

        public string GroupProduct { get; set; } = null!;
        public string? Remark { get; set; }
        public bool? TriggerApproval { get; set; }
        public bool? TriggerDeletion { get; set; }

        public virtual ICollection<TgroupProductList> TgroupProductLists { get; set; }
    }
}
