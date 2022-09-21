using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TextUigenwebService
    {
        public long TextUigenwebServiceId { get; set; }
        public string SpName { get; set; } = null!;
        public short BeforeAfterFinal { get; set; }
        public short ApproveRejectSave { get; set; }
        public string ActionType { get; set; } = null!;
        public long? Id { get; set; }
        public string? AuditUser { get; set; }
        public DateTime? AuditTime { get; set; }
        public string? AuditHost { get; set; }
        public bool? ResultStatus { get; set; }
        public string? OutputMessage { get; set; }
        public string? Url { get; set; }
        public string? MethodName { get; set; }
        public string? RequestBody { get; set; }
        public string? SoapAction { get; set; }
        public string? ResponseText { get; set; }
        public string? Remarks { get; set; }
    }
}
