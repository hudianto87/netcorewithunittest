using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TftTransLookup
    {
        public TftTransLookup()
        {
            TftFileTemplateColumns = new HashSet<TftFileTemplateColumn>();
        }

        public long TtransLookupId { get; set; }
        public int LookupDbno { get; set; }
        public string LookupName { get; set; } = null!;
        public string TableName { get; set; } = null!;
        public string? WhereClause { get; set; }
        public string InputColumnName1 { get; set; } = null!;
        public string? InputColumnName2 { get; set; }
        public string? InputColumnName3 { get; set; }
        public string? InputColumnName4 { get; set; }
        public string OutputColumnName1 { get; set; } = null!;
        public string? OutputColumnName2 { get; set; }
        public string? OutputColumnName3 { get; set; }
        public string? OutputColumnName4 { get; set; }
        public int OutputColumnDataType1 { get; set; }
        public int? OutputColumnDataType2 { get; set; }
        public int? OutputColumnDataType3 { get; set; }
        public int? OutputColumnDataType4 { get; set; }
        public string? DefaultOutput1 { get; set; }
        public string? DefaultOutput2 { get; set; }
        public string? DefaultOutput3 { get; set; }
        public string? DefaultOutput4 { get; set; }
        public bool OutputColumnShowInPreview1 { get; set; }
        public bool? OutputColumnShowInPreview2 { get; set; }
        public bool? OutputColumnShowInPreview3 { get; set; }
        public bool? OutputColumnShowInPreview4 { get; set; }
        public string? OutputColumnAlias1 { get; set; }
        public string? OutputColumnAlias2 { get; set; }
        public string? OutputColumnAlias3 { get; set; }
        public string? OutputColumnAlias4 { get; set; }
        public int LookupCacheModeId { get; set; }
        public int ErrorHandlingOnBlankInput { get; set; }
        public int ErrorHandlingOnLookupMiss { get; set; }
        public string? Remarks { get; set; }
        public string SysCreatedBy { get; set; } = null!;
        public DateTime SysCreatedTime { get; set; }
        public string SysCreatedHost { get; set; } = null!;
        public string? SysModifiedBy { get; set; }
        public DateTime? SysModifiedTime { get; set; }
        public string? SysModifiedHost { get; set; }

        public virtual TftDb LookupDbnoNavigation { get; set; } = null!;
        public virtual ICollection<TftFileTemplateColumn> TftFileTemplateColumns { get; set; }
    }
}
