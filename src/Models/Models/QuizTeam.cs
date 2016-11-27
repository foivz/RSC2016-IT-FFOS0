using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Models.Models
{
    public class QuizTeam
    {
        public long Id { get; set; }
        public long QuizId { get; set; }
        public long TeamId { get; set; }

        #region Navigators

        public virtual Quiz Quiz { get; set; }
        public virtual Team Team { get; set; }

        #endregion Navigators
    }
}