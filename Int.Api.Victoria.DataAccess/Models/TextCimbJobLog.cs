using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TextCimbJobLog
    {
        public long IdjobLog { get; set; }
        public string? ModuleName { get; set; }
        public long? Idtransaction { get; set; }
        public long? Idcustomer { get; set; }
        public string? IdsubAccount { get; set; }
        public long? Idproduct { get; set; }
        public string? Status { get; set; }
        public string? Remark { get; set; }
        public string? Exception { get; set; }
        public string? SysCreatedBy { get; set; }
        public DateTime? SysCreatedTime { get; set; }
    }
}
