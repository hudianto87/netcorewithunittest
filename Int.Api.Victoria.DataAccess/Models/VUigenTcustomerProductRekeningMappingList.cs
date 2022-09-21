using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class VUigenTcustomerProductRekeningMappingList
    {
        public long IdcustomerProductRekeningMapping { get; set; }
        public long? Idcustomer { get; set; }
        public long? Idproduct { get; set; }
        public int? IdcustBankAccount { get; set; }
        public string? SysCreatedBy { get; set; }
        public DateTime? SysCreatedTime { get; set; }
        public string? SysApprovedBy { get; set; }
        public DateTime? SysApprovedTime { get; set; }
        public string? SysActionType { get; set; }
        public bool? SysRecStatus { get; set; }
        public byte? SysApprovalStatus { get; set; }
        public string? SysApprovalNotes { get; set; }
        public string? Customer { get; set; }
        public string? AccountNo { get; set; }
    }
}
