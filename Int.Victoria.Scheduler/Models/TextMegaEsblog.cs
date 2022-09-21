using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TextMegaEsblog
    {
        public long TesblogId { get; set; }
        public string Direction { get; set; } = null!;
        public string? ChannelId { get; set; }
        public string? AppModul { get; set; }
        public string ServiceName { get; set; } = null!;
        public string? RqUid { get; set; }
        public long? Idtransaction { get; set; }
        public string? Cif { get; set; }
        public string? RequestData { get; set; }
        public string? ResponseData { get; set; }
        public string? ResponseCode { get; set; }
        public string? ResponseDescription { get; set; }
        public string? Exception { get; set; }
        public string SysCreatedBy { get; set; } = null!;
        public DateTime SysCreatedTime { get; set; }
    }
}
