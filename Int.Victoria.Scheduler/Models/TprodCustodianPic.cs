using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TprodCustodianPic
    {
        public int CustodianPicid { get; set; }
        public int CustodianId { get; set; }
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
