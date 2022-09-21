﻿using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TgenuijourTtransactionFee
    {
        public long TgenuijourTableId { get; set; }
        public long TtransactionFeeId { get; set; }
        public string SysActionType { get; set; } = null!;
        public byte SysApprovalStatus { get; set; }
        public string? SysPendingBy { get; set; }
        public DateTime? SysPendingTime { get; set; }
        public string? SysPendingHost { get; set; }
        public string? SysApprovalNotes { get; set; }
        public string? SysApprovedBy { get; set; }
        public DateTime? SysApprovedTime { get; set; }
        public string? SysApprovedHost { get; set; }
    }
}
