using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TauditTrailTran
    {
        public long TauditTrailTransId { get; set; }
        public string? ShadowId { get; set; }
        public string? GroupName { get; set; }
        public string? TableName { get; set; }
        public string? Id { get; set; }
        public string? ActionType { get; set; }
        public string? SysPendingBy { get; set; }
        public DateTime? SysPendingTime { get; set; }
        public string? SysPendingHost { get; set; }
        public string? SysApproveBy { get; set; }
        public DateTime? SysApproveTime { get; set; }
        public string? SysApproveHost { get; set; }
        public string? ColumnName { get; set; }
        public string? OldValue { get; set; }
        public string? NewValue { get; set; }
    }
}
