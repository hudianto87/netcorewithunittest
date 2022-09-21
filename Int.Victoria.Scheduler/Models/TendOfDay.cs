using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TendOfDay
    {
        public long TendOfDayId { get; set; }
        public DateTime Navdate { get; set; }
        public long Idproduct { get; set; }
        public long IndexHelper { get; set; }
        public string? Eodremarks { get; set; }
        public int EodtrxCount { get; set; }
        public int EodtrxSuccessCount { get; set; }
        public int EodtrxFailCount { get; set; }
        public string? UndoRemarks { get; set; }
        public int? UndoTrxCount { get; set; }
        public int? UndoTrxSuccessCount { get; set; }
        public int? UndoTrxFailCount { get; set; }
        public bool SysIsDeleted { get; set; }
        public string? SysDeletedBy { get; set; }
        public DateTime? SysDeletedTime { get; set; }
        public string? SysDeletedHost { get; set; }
        public string SysCreatedBy { get; set; } = null!;
        public DateTime SysCreatedTime { get; set; }
        public string SysCreatedHost { get; set; } = null!;
        public string? SysModifiedBy { get; set; }
        public DateTime? SysModifiedTime { get; set; }
        public string? SysModifiedHost { get; set; }
        public bool? IsAutoEod { get; set; }
        public string? EoderrorMessage { get; set; }

        public virtual Tproduct IdproductNavigation { get; set; } = null!;
    }
}
