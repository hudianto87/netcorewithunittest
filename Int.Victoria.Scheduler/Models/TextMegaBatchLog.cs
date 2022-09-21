using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TextMegaBatchLog
    {
        public long TextMegaBatchLogId { get; set; }
        public string? BatchType { get; set; }
        public string? Direction { get; set; }
        public string? FileName { get; set; }
        public string? SenderHost { get; set; }
        public string? ReceiverHost { get; set; }
        public string? DestPath { get; set; }
        public DateTime? CreatedTime { get; set; }
        public string? Exception { get; set; }
        public string? SysCreatedBy { get; set; }
        public string? SysCreatedHost { get; set; }
        public string? ResponseCode { get; set; }
        public string? LogMessage { get; set; }
    }
}
