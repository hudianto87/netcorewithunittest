using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TcustBankAccountProduct
    {
        public long Id { get; set; }
        public string? UnitHolderIdno { get; set; }
        public string? ProductCode { get; set; }
        public int? Sequence { get; set; }
        public string? AccountNo { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
    }
}
