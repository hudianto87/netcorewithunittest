﻿using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TgenuitempTftFileTemplateColumn
    {
        public long TgenuitempTableId { get; set; }
        public string TgenuitempSessionId { get; set; } = null!;
        public long? TgenuitempIdmaster { get; set; }
        public long? TgenuitempIddetail { get; set; }
        public short TgenuitempChangeFlag { get; set; }
        public string TgenuitempSysCreatedBy { get; set; } = null!;
        public DateTime TgenuitempSysCreatedTime { get; set; }
        public string TgenuitempSysCreatedHost { get; set; } = null!;
        public string? TgenuitempSysModifiedBy { get; set; }
        public DateTime? TgenuitempSysModifiedTime { get; set; }
        public string? TgenuitempSysModifiedHost { get; set; }
        public long? TfileTemplateColumnId { get; set; }
        public long? TfileTemplateId { get; set; }
        public int? SeqNo { get; set; }
        public string? ColumnName { get; set; }
        public int? TrefColumnDataTypeId { get; set; }
        public bool? ShowInPreview { get; set; }
        public string? DefaultValue { get; set; }
        public int? ErrorHandlingOnBlankInput { get; set; }
        public string? Format { get; set; }
        public string? Culture { get; set; }
        public long? TtransLookupId { get; set; }
        public string? SysCreatedBy { get; set; }
        public DateTime? SysCreatedTime { get; set; }
        public string? SysCreatedHost { get; set; }
        public string? SysModifiedBy { get; set; }
        public DateTime? SysModifiedTime { get; set; }
        public string? SysModifiedHost { get; set; }
    }
}
