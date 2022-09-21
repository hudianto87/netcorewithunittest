using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class ZzztransactionMig
    {
        public string? TrxIdPk { get; set; }
        public string? Channel { get; set; }
        public string? Cif { get; set; }
        public string? ProductCode { get; set; }
        public string? TrxType { get; set; }
        public string? Descrip { get; set; }
        public double? Units { get; set; }
        public DateTime? TrxDate { get; set; }
        public string SysCreatedBy { get; set; } = null!;
        public DateTime SysCreatedTime { get; set; }
        public string SysCreatedHost { get; set; } = null!;
    }
}
