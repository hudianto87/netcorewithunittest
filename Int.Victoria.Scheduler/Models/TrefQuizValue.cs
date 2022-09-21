using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TrefQuizValue
    {
        public Guid QuizInfo { get; set; }
        public Guid OptionText { get; set; }
        public int? OptionValue { get; set; }

        public virtual TrefCustQuiz QuizInfoNavigation { get; set; } = null!;
    }
}
