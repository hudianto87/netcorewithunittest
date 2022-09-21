using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TproductBundlingDetail
    {
        public long TproductBundlingDetailId { get; set; }
        public long TproductBundlingId { get; set; }
        public long Idproduct { get; set; }
        public double Percentage { get; set; }
        public DateTime SysCreatedDate { get; set; }
        public string SysCreatedBy { get; set; } = null!;
        public DateTime? SysModifiedDate { get; set; }
        public string? SysModifiedBy { get; set; }

        public virtual Tproduct IdproductNavigation { get; set; } = null!;
        public virtual TproductBundling TproductBundling { get; set; } = null!;
    }
}
