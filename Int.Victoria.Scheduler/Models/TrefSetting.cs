using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TrefSetting
    {
        public string SetCode { get; set; } = null!;
        public string? SetValue { get; set; }
        public string? SetDataType { get; set; }
        public string? SetDescription { get; set; }
        public byte? IsActive { get; set; }
        public DateTime? DateModified { get; set; }
    }
}
