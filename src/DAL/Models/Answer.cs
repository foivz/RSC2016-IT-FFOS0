using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Models
{
    [Table("Answers")]
    public class Answer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        public long QuestionId { get; set; }
        public string AnswerText { get; set; }

        [DefaultValue(false)]
        public bool? Correct { get; set; }

        #region Navigators

        [ForeignKey("QuestionId")]
        public virtual Question Question { get; set; }

        #endregion Navigators
    }
}