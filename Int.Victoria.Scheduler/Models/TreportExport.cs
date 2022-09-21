using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TreportExport
    {
        public TreportExport()
        {
            Tattachments = new HashSet<Tattachment>();
            TreportExportTemplates = new HashSet<TreportExportTemplate>();
        }

        public long TreportExportId { get; set; }
        public string ReportName { get; set; } = null!;
        public string Rdlname { get; set; } = null!;
        public string Parameter { get; set; } = null!;
        public bool? IsIntroduction { get; set; }
        public long? IntroductionFor { get; set; }
        public string? Description { get; set; }
        public DateTime SysCreatedDate { get; set; }
        public string SysCreatedBy { get; set; } = null!;
        public DateTime? SysModifiedDate { get; set; }
        public string? SysModifiedBy { get; set; }

        public virtual ICollection<Tattachment> Tattachments { get; set; }
        public virtual ICollection<TreportExportTemplate> TreportExportTemplates { get; set; }
    }
}
