using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TproductGroupList
    {
        public int GroupId { get; set; }
        public string ProductCode { get; set; } = null!;
        public int? SeqNo { get; set; }

        public virtual TproductGroup Group { get; set; } = null!;
    }
}
