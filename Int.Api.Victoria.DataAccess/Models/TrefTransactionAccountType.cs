using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TrefTransactionAccountType
    {
        public short TransAccountType { get; set; }
        public string? TransAccountName { get; set; }
        public short? RecIsActive { get; set; }
    }
}
