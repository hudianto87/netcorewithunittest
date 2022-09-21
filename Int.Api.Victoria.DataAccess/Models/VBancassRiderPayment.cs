using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class VBancassRiderPayment
    {
        public long IdbancAssuranceRiderPremi { get; set; }
        public string? PolisNo { get; set; }
        public long? IdbancAssuranceRider { get; set; }
        public double? RiderPremi { get; set; }
        public double? UangPertanggungan { get; set; }
        public bool? Status { get; set; }
        public byte? SysApprovalStatus { get; set; }
        public string? SysActionType { get; set; }
    }
}
