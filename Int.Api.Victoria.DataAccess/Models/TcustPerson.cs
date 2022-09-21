using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TcustPerson
    {
        public string UnitHolderIdno { get; set; } = null!;
        public string NamePerson { get; set; } = null!;
        public string? PhonePerson { get; set; }
        public string? TypePerson { get; set; }
    }
}
