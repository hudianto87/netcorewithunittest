using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TrefCompanyType
    {
        public string CompanyType { get; set; } = null!;
        public string? CompanyDetail { get; set; }
        public int? ExternalCode { get; set; }
    }
}
