using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TautoEodlogResult
    {
        public long TautoEodlogResultId { get; set; }
        public long? Idproduct { get; set; }
        public string? ProductCode { get; set; }
        public string? ProductName { get; set; }
        public bool? ValidTeod { get; set; }
        public bool? ValidTnav { get; set; }
        public bool? ValidProd { get; set; }
        public string? ErrorMessage { get; set; }
        public bool? IsError { get; set; }
        public bool? IsErrorUndo { get; set; }
        public int? SuccessCounter1 { get; set; }
        public int? FailCounter1 { get; set; }
        public int? TotalTrxCount1 { get; set; }
        public int? SuccessCounter2 { get; set; }
        public int? FailCounter2 { get; set; }
        public int? TotalTrxCount2 { get; set; }
        public DateTime? CreatedTime { get; set; }
    }
}
