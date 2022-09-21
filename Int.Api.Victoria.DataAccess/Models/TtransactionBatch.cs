using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TtransactionBatch
    {
        public long BatchId { get; set; }
        public string? ProductCode { get; set; }
        public string? Idcategory { get; set; }
        public int? BatchCounter { get; set; }
        public DateTime? BatchDate { get; set; }
        public string? BatchFile { get; set; }
        public string? BatchRefNo { get; set; }
        public string? EntryMode { get; set; }
        public byte? RecActive { get; set; }

        public virtual TrefCategory? IdcategoryNavigation { get; set; }
    }
}
