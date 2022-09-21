using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TautoSubRegisterLogDetail
    {
        public long TautoSubRegisterLogDetailId { get; set; }
        public long TautoSubRegisterLogId { get; set; }
        public long TautoSubRegisterId { get; set; }
        public long? TtransactionId { get; set; }
        public DateTime LogDate { get; set; }
        public string? Remarks { get; set; }

        public virtual TautoSubRegister TautoSubRegister { get; set; } = null!;
        public virtual TautoSubRegisterLog TautoSubRegisterLog { get; set; } = null!;
    }
}
