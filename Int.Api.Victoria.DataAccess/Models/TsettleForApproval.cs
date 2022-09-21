using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TsettleForApproval
    {
        public string Idtransaction { get; set; } = null!;
        public bool SynchToJha { get; set; }
        public string? ApprovedBy { get; set; }
        public byte ApprovalStatus { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; } = null!;
    }
}
