﻿using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TrefRecStatus
    {
        public byte RecStatus { get; set; }
        public string StatusName { get; set; } = null!;
        public byte? RecOrder { get; set; }
    }
}
