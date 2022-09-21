using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TcustProfile
    {
        public string UnitHolderIdNo { get; set; } = null!;
        public Guid QuestionId { get; set; }
        public Guid? OptionId { get; set; }
    }
}
