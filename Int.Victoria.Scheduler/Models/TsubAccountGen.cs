﻿using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TsubAccountGen
    {
        public long TsubAccountGenId { get; set; }
        public long Idproduct { get; set; }
        public DateTime Date { get; set; }
        public int? LastId { get; set; }
    }
}
