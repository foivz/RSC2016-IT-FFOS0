using Models.Models.Lookup;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Models.Models
{
    public class QuizRound
    {
        public long Id { get; set; }

        public long CategoryId { get; set; }
        public long TypeId { get; set; }
        public long QuizId { get; set; }
        public int NumberOfQuestions { get; set; }

        public bool? TurboModifier { get; set; }

        #region Navigators

        public virtual Category Category { get; set; }

        public virtual QuestionType Type { get; set; }

        public virtual Quiz Quiz { get; set; }

        #endregion Navigators
    }
}