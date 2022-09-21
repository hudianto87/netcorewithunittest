﻿using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TrefProfileQuestion
    {
        public TrefProfileQuestion()
        {
            TcustomerRiskProfileAnswerTemps = new HashSet<TcustomerRiskProfileAnswerTemp>();
            TcustomerRiskProfileAnswers = new HashSet<TcustomerRiskProfileAnswer>();
            TrefProfileQuestionOptions = new HashSet<TrefProfileQuestionOption>();
        }

        public int QuestionId { get; set; }
        public string? QuestionTitle { get; set; }
        public string? QuestionText { get; set; }
        public short? SeqNo { get; set; }
        public bool? IsActive { get; set; }
        public string? Remarks { get; set; }
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
        public string? InvestorType { get; set; }

        public virtual ICollection<TcustomerRiskProfileAnswerTemp> TcustomerRiskProfileAnswerTemps { get; set; }
        public virtual ICollection<TcustomerRiskProfileAnswer> TcustomerRiskProfileAnswers { get; set; }
        public virtual ICollection<TrefProfileQuestionOption> TrefProfileQuestionOptions { get; set; }
    }
}
