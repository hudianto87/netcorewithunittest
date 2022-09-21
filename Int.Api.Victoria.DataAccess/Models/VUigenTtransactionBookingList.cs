using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class VUigenTtransactionBookingList
    {
        public long IdtransactionBooking { get; set; }
        public string? Idcategory { get; set; }
        public string? Idstatus { get; set; }
        public string? ReferenceNo { get; set; }
        public long? Idcustomer { get; set; }
        public long? Idproduct { get; set; }
        public long? Idsales { get; set; }
        public double? Amount { get; set; }
        public double? Units { get; set; }
        public double? FeeAmount { get; set; }
        public double? NetAmount { get; set; }
        public DateTime? SysCreatedTime { get; set; }
        public string? CustomerName { get; set; }
        public string? ProductName { get; set; }
        public string? SalesName { get; set; }
        public byte? SysApprovalStatus { get; set; }
        public string? SysActionType { get; set; }
    }
}
