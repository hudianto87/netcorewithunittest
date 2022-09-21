using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TproductComposition
    {
        public int IdproductComposition { get; set; }
        public string ProductCode { get; set; } = null!;
        public string Type { get; set; } = null!;
        public int Value { get; set; }
    }
}
