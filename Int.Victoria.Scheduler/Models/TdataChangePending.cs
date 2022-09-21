using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TdataChangePending
    {
        public long DataChangeId { get; set; }
        public string ChangeType { get; set; } = null!;
        public long ApprovalId { get; set; }
        public string? TableName { get; set; }
        public string? Pkfield { get; set; }
        public string? Pkvalue { get; set; }
        public string? FieldName { get; set; }
        public string? FieldOldValue { get; set; }
        public string? FieldNewValue { get; set; }
        public DateTime? RecCreatedDate { get; set; }
        public string? RecCreatedBy { get; set; }
    }
}
