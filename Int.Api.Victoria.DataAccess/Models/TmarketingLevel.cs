using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TmarketingLevel
    {
        public TmarketingLevel()
        {
            InverseLevelCodeParentNavigation = new HashSet<TmarketingLevel>();
            TcustomerSalesHistories = new HashSet<TcustomerSalesHistory>();
        }

        public string LevelCode { get; set; } = null!;
        public string? LevelCodeParent { get; set; }
        public string LevelName { get; set; } = null!;
        public short Sort { get; set; }

        public virtual TmarketingLevel? LevelCodeParentNavigation { get; set; }
        public virtual ICollection<TmarketingLevel> InverseLevelCodeParentNavigation { get; set; }
        public virtual ICollection<TcustomerSalesHistory> TcustomerSalesHistories { get; set; }
    }
}
