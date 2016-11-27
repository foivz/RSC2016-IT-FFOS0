using DAL.Models.Lookup;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Models
{
    [Table("QuizRounds")]
    public class QuizRound
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        public long CategoryId { get; set; }
        public long TypeId { get; set; }
        public long QuizId { get; set; }
        public int NumberOfQuestions { get; set; }

        [DefaultValue(false)]
        public bool? TurboModifier { get; set; }

        #region Navigators

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }

        [ForeignKey("TypeId")]
        public virtual QuestionType Type { get; set; }

        [ForeignKey("QuizId")]
        public virtual Quiz Quiz { get; set; }

        #endregion Navigators
    }
}