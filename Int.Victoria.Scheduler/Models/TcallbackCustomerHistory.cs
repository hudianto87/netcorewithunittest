using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TcallbackCustomerHistory
    {
        public long TcallbackCustomerHistoryId { get; set; }
        public long Idcustomer { get; set; }
        public int? KycCounter { get; set; }
        public string? PicCallCenter { get; set; }
        public string? CallbackStatus { get; set; }
        public string? SysRecStatus { get; set; }
        public string? SysCreatedBy { get; set; }
        public DateTime? SysCreatedTime { get; set; }
        public string? SysCreatedHost { get; set; }
        public string? SysUploadBy { get; set; }
        public DateTime? SysUploadTime { get; set; }
        public string? SysUploadHost { get; set; }
        public string? SysApprovedBy { get; set; }
        public DateTime? SysApprovedTime { get; set; }
        public string? SysApprovedHost { get; set; }
        public string? Remark { get; set; }
    }
}
