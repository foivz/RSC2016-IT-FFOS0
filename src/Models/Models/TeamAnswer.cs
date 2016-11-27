using Models.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Models.Models
{
    public class TeamAnswer
    {
        public long Id { get; set; }

        public long QuizId { get; set; }
        public long RoundId { get; set; }
        public long TeamId { get; set; }
        public long QuestionId { get; set; }
        public string Answer { get; set; }
        public bool Correct { get; set; }

        #region Navigators

        public virtual Quiz Quiz { get; set; }

        public virtual QuizRound Round { get; set; }

        public virtual Team Team { get; set; }

        public virtual Question Question { get; set; }

        #endregion Navigators
    }
}