using HackathonVZ.Data;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    [Table("TeamMembers")]
    public class TeamMember
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        public long TeamId { get; set; }
        public string UserId { get; set; }

        [DefaultValue(false)]
        public bool Leader { get; set; }

        #region Navigators

        [ForeignKey("TeamId")]
        public virtual Team Team { get; set; }

        [ForeignKey("UserId")]
        public virtual ApplicationUser User { get; set; }

        #endregion Navigators
    }
}