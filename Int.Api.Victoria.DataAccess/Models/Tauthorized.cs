using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class Tauthorized
    {
        public int AuthorId { get; set; }
        public string? Trans { get; set; }
        public string AuthorName1 { get; set; } = null!;
        public string Position1 { get; set; } = null!;
        public string? AuthorName2 { get; set; }
        public string? Position2 { get; set; }
    }
}
