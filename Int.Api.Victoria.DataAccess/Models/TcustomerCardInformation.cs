using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TcustomerCardInformation
    {
        public long IdtypeCard { get; set; }
        public long Idcustomer { get; set; }
        public string TypeCard { get; set; } = null!;
        public string Idcard { get; set; } = null!;
        public DateTime? RegisteredCardDate { get; set; }
        public DateTime? ExpiredCardDate { get; set; }
        public string CreatedUser { get; set; } = null!;
        public DateTime CreatedDate { get; set; }
        public string? LastUpdateUser { get; set; }
        public DateTime? LastUpdateDate { get; set; }

        public virtual Tcustomer IdcustomerNavigation { get; set; } = null!;
    }
}
