using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class ZzzTcustBankAccountHistory
    {
        public long TdataId { get; set; }
        public long? Idcustomer { get; set; }
        public string? AccountNo { get; set; }
        public string? AccountName { get; set; }
        public int? IdbankBranch { get; set; }
        public int? Idcurrency { get; set; }
        public int? IdaccountBankType { get; set; }
        public bool? IsMandatory { get; set; }
        public bool? IsPriority { get; set; }
        public bool? IsTaxAmnesty { get; set; }
        public byte? PaymentSeqCode { get; set; }
        public string SysCreatedBy { get; set; } = null!;
        public DateTime SysCreatedTime { get; set; }
        public string SysCreatedHost { get; set; } = null!;
    }
}
