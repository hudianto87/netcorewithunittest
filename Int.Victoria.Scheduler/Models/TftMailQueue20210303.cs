using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TftMailQueue20210303
    {
        public long TmailQueueId { get; set; }
        public short QueueStatus { get; set; }
        public long? TsendMailAccountId { get; set; }
        public string MailTo { get; set; } = null!;
        public string? MailCc { get; set; }
        public string? MailBcc { get; set; }
        public string? ReplyTo { get; set; }
        public string Subject { get; set; } = null!;
        public string Body { get; set; } = null!;
        public bool IsBodyHtml { get; set; }
        public string Source { get; set; } = null!;
        public string? ExternalCode01 { get; set; }
        public string? ExternalCode02 { get; set; }
        public string? ExternalCode03 { get; set; }
        public string? ExternalCode04 { get; set; }
        public short SendFailCount { get; set; }
        public string? ErrorLog { get; set; }
        public DateTime? LastAttachmentBeginTime { get; set; }
        public DateTime? LastSendBeginTime { get; set; }
        public DateTime? LastSendEndTime { get; set; }
        public string? Remarks { get; set; }
        public string SysCreatedBy { get; set; } = null!;
        public DateTime SysCreatedTime { get; set; }
        public string SysCreatedHost { get; set; } = null!;
        public string? SysModifiedBy { get; set; }
        public DateTime? SysModifiedTime { get; set; }
        public string? SysModifiedHost { get; set; }
    }
}
