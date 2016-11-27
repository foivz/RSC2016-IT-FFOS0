using Models.Models.Lookup;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Question
    {
        public long Id { get; set; }

        public string QuestionText { get; set; }
        public long CategoryId { get; set; }
        public long TypeId { get; set; }
        public long? ImageId { get; set; }

        #region Navigators

        public virtual Category Category { get; set; }

        public virtual QuestionType QuestionType { get; set; }

        public virtual Image Image { get; set; }

        #endregion Navigators
    }
}