﻿using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TrefModel
    {
        public long TrefModelId { get; set; }
        public long? TmodelId { get; set; }
        public long? TproductTypeId { get; set; }
        public int? MinValue { get; set; }
        public int? MaxValue { get; set; }
        public string? Description { get; set; }
        public string? Remarks { get; set; }
        public bool? IsActive { get; set; }
        public string SysCreatedBy { get; set; } = null!;
        public DateTime SysCreatedTime { get; set; }
        public string SysCreatedHost { get; set; } = null!;
        public string? SysModifiedBy { get; set; }
        public DateTime? SysModifiedTime { get; set; }
        public string? SysModifiedHost { get; set; }
        public string SysActionType { get; set; } = null!;
        public byte SysApprovalStatus { get; set; }
        public bool? SysRecStatus { get; set; }
        public string? SysPendingBy { get; set; }
        public DateTime? SysPendingTime { get; set; }
        public string? SysPendingHost { get; set; }
        public string? SysApprovalNotes { get; set; }
        public string? SysApprovedBy { get; set; }
        public DateTime? SysApprovedTime { get; set; }
        public string? SysApprovedHost { get; set; }
        public string? SysDeletedBy { get; set; }
        public DateTime? SysDeletedTime { get; set; }
        public string? SysDeletedHost { get; set; }

        public virtual Tmodel? Tmodel { get; set; }
    }
}
