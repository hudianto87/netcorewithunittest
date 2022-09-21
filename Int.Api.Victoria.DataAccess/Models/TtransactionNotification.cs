using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TtransactionNotification
    {
        public long TtransactionNotificationId { get; set; }
        public int CreatedOnPageAccessStatusId { get; set; }
        public long Idtransaction { get; set; }
        public string Message { get; set; } = null!;
        public string? NewIdstatus { get; set; }
        public string SysCreatedBy { get; set; } = null!;
        public DateTime SysCreatedTime { get; set; }
        public string SysCreatedHost { get; set; } = null!;
        public string? SysModifiedBy { get; set; }
        public DateTime? SysModifiedTime { get; set; }
        public string? SysModifiedHost { get; set; }

        public virtual Ttransaction IdtransactionNavigation { get; set; } = null!;
    }
}
