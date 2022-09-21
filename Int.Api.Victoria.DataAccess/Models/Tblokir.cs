using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class Tblokir
    {
        public long Idblokir { get; set; }
        public string UnitHolderIdNo { get; set; } = null!;
        public string ProductCode { get; set; } = null!;
        public double? UnitBlokir { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? TipeBlokir { get; set; }
        public string? Remark { get; set; }
        public string? EntryUser { get; set; }
        public DateTime? EntryDate { get; set; }
        public string? AuthUser { get; set; }
        public DateTime? AuthDate { get; set; }
        public string? Idstatus { get; set; }

        public virtual TrefStatus? IdstatusNavigation { get; set; }
    }
}
