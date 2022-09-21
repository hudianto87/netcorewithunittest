using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TextBtpnRtgssettlementTransaction
    {
        public long TextBtpnRtgssettlementTransactionId { get; set; }
        public long TextBtpnRtgssettlementId { get; set; }
        public long Idtransaction { get; set; }

        public virtual TextBtpnRtgssettlement TextBtpnRtgssettlement { get; set; } = null!;
    }
}
