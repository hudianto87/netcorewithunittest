using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TprodDistAgreement
    {
        public int DistAgreementId { get; set; }
        public int? DistributorId { get; set; }
        public string? DocTitle { get; set; }
        public string? DocLocation { get; set; }
        public DateTime? DocDate { get; set; }
        public string? Contents { get; set; }
    }
}
