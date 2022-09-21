using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TextBtpnRtgssettlementStatus
    {
        public TextBtpnRtgssettlementStatus()
        {
            TextBtpnRtgssettlements = new HashSet<TextBtpnRtgssettlement>();
        }

        public int TextBtpnRtgssettlementStatusId { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }

        public virtual ICollection<TextBtpnRtgssettlement> TextBtpnRtgssettlements { get; set; }
    }
}
