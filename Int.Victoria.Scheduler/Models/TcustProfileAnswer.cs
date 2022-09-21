using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TcustProfileAnswer
    {
        public long IdcustProfileAnswer { get; set; }
        public long Idcustomer { get; set; }
        public int QuestionOptionId { get; set; }
        public int OptionValue { get; set; }
        public string? ReferenceNo { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime? LastModifiedDate { get; set; }
        public string? LastModifiedBy { get; set; }

        public virtual Tcustomer IdcustomerNavigation { get; set; } = null!;
        public virtual TrefProfileQuestionOption QuestionOption { get; set; } = null!;
    }
}
