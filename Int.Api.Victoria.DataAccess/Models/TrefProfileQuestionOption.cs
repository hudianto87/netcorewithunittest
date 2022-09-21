using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TrefProfileQuestionOption
    {
        public TrefProfileQuestionOption()
        {
            TcustProfileAnswers = new HashSet<TcustProfileAnswer>();
            TcustomerRiskProfileAnswerTemps = new HashSet<TcustomerRiskProfileAnswerTemp>();
            TcustomerRiskProfileAnswers = new HashSet<TcustomerRiskProfileAnswer>();
        }

        public int QuestionOptionId { get; set; }
        public string OptionId { get; set; } = null!;
        public int QuestionId { get; set; }
        public string? OptionText { get; set; }
        public int? OptionValue { get; set; }
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

        public virtual TrefProfileQuestion Question { get; set; } = null!;
        public virtual ICollection<TcustProfileAnswer> TcustProfileAnswers { get; set; }
        public virtual ICollection<TcustomerRiskProfileAnswerTemp> TcustomerRiskProfileAnswerTemps { get; set; }
        public virtual ICollection<TcustomerRiskProfileAnswer> TcustomerRiskProfileAnswers { get; set; }
    }
}
