using HackathonVZ.Data;

namespace Models.Models
{
    public class TeamMember
    {
        public long Id { get; set; }
        public long TeamId { get; set; }
        public string UserId { get; set; }
        public bool Leader { get; set; }

        #region Navigators

        public virtual Team Team { get; set; }

        public virtual ApplicationUser User { get; set; }

        #endregion Navigators
    }
}