using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class Tiso8583log
    {
        public long LogId { get; set; }
        public string ProcessingCode { get; set; } = null!;
        public string RefNo { get; set; } = null!;
        public bool IsReverse { get; set; }
        public long? Idtransaction { get; set; }
        public string? Cif { get; set; }
        public string RequestMessage { get; set; } = null!;
        public string? ResponseMessage { get; set; }
        public string? ResponseCode { get; set; }
        public string? Remarks { get; set; }
        public string SysCreatedBy { get; set; } = null!;
        public DateTime SysCreatedTime { get; set; }
    }
}
