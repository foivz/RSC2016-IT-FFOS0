using Models.Models.Lookup;

namespace Models.Models
{
    public class RoundQuestion
    {
        public long Id { get; set; }

        public long QuestionId { get; set; }
        public long? ModifierId { get; set; }
        public long RoundId { get; set; }
        public bool Locked { get; set; }

        #region Navigators

        public virtual Question Question { get; set; }

        public virtual Modifier Modifier { get; set; }

        #endregion Navigators
    }
}