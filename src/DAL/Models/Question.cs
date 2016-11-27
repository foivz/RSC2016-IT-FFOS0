using DAL.Models.Lookup;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Models
{
    [Table("Questions")]
    public class Question
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        public string QuestionText { get; set; }
        public long CategoryId { get; set; }
        public long TypeId { get; set; }
        public long? ImageId { get; set; }

        #region Navigators

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }

        [ForeignKey("TypeId")]
        public virtual QuestionType QuestionType { get; set; }

        [ForeignKey("ImageId")]
        public virtual Image Image { get; set; }

        #endregion Navigators
    }
}