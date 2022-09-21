using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class Tattachment
    {
        public long TattachmentId { get; set; }
        public long TcustomerId { get; set; }
        public DateTime Date { get; set; }
        public long TreportExportId { get; set; }
        public string FileName { get; set; } = null!;
        public string Path { get; set; } = null!;
        public string Urlpath { get; set; } = null!;
        public DateTime SysCreatedDate { get; set; }
        public string SysCreatedBy { get; set; } = null!;
        public DateTime? SysModifiedDate { get; set; }
        public string? SysModifiedBy { get; set; }

        public virtual TreportExport TreportExport { get; set; } = null!;
    }
}
