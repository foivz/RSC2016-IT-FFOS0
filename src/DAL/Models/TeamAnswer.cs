using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Models
{
    [Table("TeamAnswers")]
    public class TeamAnswer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        public long QuizId { get; set; }
        public long RoundId { get; set; }
        public long TeamId { get; set; }
        public long QuestionId { get; set; }
        public string Answer { get; set; }
        public bool Correct { get; set; }

        #region Navigators

        [ForeignKey("QuizId")]
        public virtual Quiz Quiz { get; set; }

        [ForeignKey("RoundId")]
        public virtual QuizRound Round { get; set; }

        [ForeignKey("TeamId")]
        public virtual Team Team { get; set; }

        [ForeignKey("QuestionId")]
        public virtual Question Question { get; set; }

        #endregion Navigators
    }
}