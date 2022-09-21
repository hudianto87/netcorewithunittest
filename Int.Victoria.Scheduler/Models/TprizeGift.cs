using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TprizeGift
    {
        public string PrizeId { get; set; } = null!;
        public byte Sequence { get; set; }
        public string? GiftName { get; set; }
        public string? Description { get; set; }

        public virtual Tprize Prize { get; set; } = null!;
    }
}
