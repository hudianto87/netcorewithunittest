﻿using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TrefApprovalStatus
    {
        public byte ApprovalStatus { get; set; }
        public string StatusName { get; set; } = null!;
        public byte? RecOrder { get; set; }
    }
}
