using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TcustomerReport
    {
        public long TcustomerReportId { get; set; }
        public string ReportName { get; set; } = null!;
        public string ReportPath { get; set; } = null!;
        public bool IsActive { get; set; }
        public string SysCreatedBy { get; set; } = null!;
        public DateTime SysCreatedDate { get; set; }
        public string? SysModifiedBy { get; set; }
        public DateTime? SysModifiedDate { get; set; }

        public virtual TcustomerReportTemplate TcustomerReportTemplate { get; set; } = null!;
    }
}
