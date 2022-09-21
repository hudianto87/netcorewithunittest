using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TcustProfile
    {
        public string UnitHolderIdNo { get; set; } = null!;
        public Guid QuestionId { get; set; }
        public Guid? OptionId { get; set; }
    }
}
