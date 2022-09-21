using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TrefCustQuiz
    {
        public TrefCustQuiz()
        {
            TrefQuizValues = new HashSet<TrefQuizValue>();
        }

        /// <summary>
        /// The title appears in the header of question
        /// </summary>
        public Guid QuizInfo { get; set; }
        /// <summary>
        /// The question text
        /// </summary>
        public string QuizText { get; set; } = null!;

        public virtual ICollection<TrefQuizValue> TrefQuizValues { get; set; }
    }
}
