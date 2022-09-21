using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TcustomerCorporateCardHolder
    {
        public long IdCardHolder { get; set; }
        public long IdCustomer { get; set; }
        public string FirstName { get; set; } = null!;
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public string? Position { get; set; }
        public string? Npwpno { get; set; }
        public DateTime? NpwpregisterDate { get; set; }
        public string? Ktpno { get; set; }
        public DateTime? KtpexpiredDate { get; set; }
        public string? Kitasno { get; set; }
        public DateTime? KitasexpiredDate { get; set; }
        public string? PassportNo { get; set; }
        public DateTime? PassportExpiredDate { get; set; }
        public string? Skdno { get; set; }
        public DateTime? SkdexpiredDate { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateUser { get; set; } = null!;
        public string? LastUpdateUser { get; set; }
        public DateTime? LastUpdateDate { get; set; }

        public virtual Tcustomer IdCustomerNavigation { get; set; } = null!;
    }
}
