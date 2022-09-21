using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TdueDate
    {
        public string? Id { get; set; }
        public DateTime? Navdate { get; set; }
        public DateTime? DueDate { get; set; }
    }
}
