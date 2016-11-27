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
    [Table("RoundQuestions")]
    public class RoundQuestion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        public long QuestionId { get; set; }
        public long? ModifierId { get; set; }
        public long RoundId { get; set; }

        [DefaultValue(false)]
        public bool Locked { get; set; }

        #region Navigators

        [ForeignKey("QuestionId")]
        public virtual Question Question { get; set; }

        [ForeignKey("ModifierId")]
        public virtual Modifier Modifier { get; set; }

        #endregion Navigators
    }
}