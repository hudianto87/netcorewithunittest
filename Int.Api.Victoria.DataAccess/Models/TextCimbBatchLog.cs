using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TextCimbBatchLog
    {
        public long TextCimbBatchLogId { get; set; }
        public string? BatchType { get; set; }
        public string? Direction { get; set; }
        public string? FileName { get; set; }
        public string? SenderHost { get; set; }
        public string? ReceiverHost { get; set; }
        public string? DestPath { get; set; }
        public DateTime? CreatedTime { get; set; }
        public string? Exception { get; set; }
    }
}
