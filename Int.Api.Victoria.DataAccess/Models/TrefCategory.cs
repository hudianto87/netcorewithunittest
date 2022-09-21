using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TrefCategory
    {
        public TrefCategory()
        {
            TproductTransactionFees = new HashSet<TproductTransactionFee>();
            TtransactionBatches = new HashSet<TtransactionBatch>();
        }

        public string Idcategory { get; set; } = null!;
        public string? CategoryName { get; set; }
        public int? CounterId { get; set; }
        public byte? SortOrder { get; set; }

        public virtual ICollection<TproductTransactionFee> TproductTransactionFees { get; set; }
        public virtual ICollection<TtransactionBatch> TtransactionBatches { get; set; }
    }
}
