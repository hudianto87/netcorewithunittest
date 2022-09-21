using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class VUigenTholdUnitList
    {
        public long TholdUnitId { get; set; }
        public byte? HoldType { get; set; }
        public long? Idcustomer { get; set; }
        public long? IdsubAccount { get; set; }
        public long? OldTholdUnitId { get; set; }
        public double? Units { get; set; }
        public long? CollateralId { get; set; }
        public string? SysActionType { get; set; }
        public byte? SysApprovalStatus { get; set; }
        public bool? SysRecStatus { get; set; }
        public DateTime? SysCreatedTime { get; set; }
        public DateTime? SysApprovedTime { get; set; }
        public string CustDisp { get; set; } = null!;
        public string ProdDisp { get; set; } = null!;
        public string SubAccountDisp { get; set; } = null!;
    }
}
