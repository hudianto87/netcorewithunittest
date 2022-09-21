using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class Tprize
    {
        public Tprize()
        {
            TprizeGifts = new HashSet<TprizeGift>();
        }

        public string PrizeId { get; set; } = null!;
        public string? PrizeName { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public virtual ICollection<TprizeGift> TprizeGifts { get; set; }
    }
}
