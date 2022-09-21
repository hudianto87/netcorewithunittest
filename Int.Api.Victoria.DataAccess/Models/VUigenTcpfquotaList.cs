using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class VUigenTcpfquotaList
    {
        public long TcpfquotaId { get; set; }
        public int? CpfquotaTrxType { get; set; }
        public long? AgentIdfrom { get; set; }
        public long? AgentIdto { get; set; }
        public long? Idproduct { get; set; }
        public double? Amount { get; set; }
        public DateTime? SysCreatedTime { get; set; }
        public DateTime? SysApprovedTime { get; set; }
        public string? SysActionType { get; set; }
        public byte? SysApprovalStatus { get; set; }
        public bool? SysRecStatus { get; set; }
        public string AgentFrom { get; set; } = null!;
        public string AgentTo { get; set; } = null!;
        public string? Product { get; set; }
    }
}
