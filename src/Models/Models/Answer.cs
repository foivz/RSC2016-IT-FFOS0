using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Answer
    {
        public long Id { get; set; }

        public long QuestionId { get; set; }
        public string AnswerText { get; set; }
        public bool? Correct { get; set; }

        #region Navigators

        public virtual Question Question { get; set; }

        #endregion Navigators
    }
}