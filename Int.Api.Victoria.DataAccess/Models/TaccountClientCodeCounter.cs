using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TaccountClientCodeCounter
    {
        public long TaccountClientCodeCounterId { get; set; }
        public string LastLetter { get; set; } = null!;
        public string LastNum { get; set; } = null!;
    }
}
