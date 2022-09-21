using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TprodDistributorPic
    {
        public int DistributorPicid { get; set; }
        public int DistributorId { get; set; }
        public string? ContactName { get; set; }
        public string? ContactTitle { get; set; }
        public string? OfficePhone { get; set; }
        public string? MobilePhone { get; set; }
        public string? FaxNo { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? PostalCode { get; set; }
        public string? Province { get; set; }
    }
}
