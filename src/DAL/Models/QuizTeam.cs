using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Models
{
    [Table("QuizTeams")]
    public class QuizTeam
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        public long QuizId { get; set; }
        public long TeamId { get; set; }

        #region Navigators

        [ForeignKey("QuizId")]
        public virtual Quiz Quiz { get; set; }

        [ForeignKey("TeamId")]
        public virtual Team Team { get; set; }

        #endregion Navigators
    }
}