using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TautoSubRegisterLog
    {
        public TautoSubRegisterLog()
        {
            TautoSubRegisterLogDetails = new HashSet<TautoSubRegisterLogDetail>();
        }

        public long TautoSubRegisterLogId { get; set; }
        public DateTime LogDate { get; set; }
        public string? Remarks { get; set; }

        public virtual ICollection<TautoSubRegisterLogDetail> TautoSubRegisterLogDetails { get; set; }
    }
}
