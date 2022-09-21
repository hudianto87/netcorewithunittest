using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TgroupMenuList
    {
        public string GroupMenu { get; set; } = null!;
        public string Idmenu { get; set; } = null!;
        public bool IsEnabled { get; set; }
        public bool? AllowWrite { get; set; }
        public bool? AllowModify { get; set; }

        public virtual TgroupMenu GroupMenuNavigation { get; set; } = null!;
    }
}
