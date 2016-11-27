using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HackathonVZ.ViewModels.Admin
{
    public class CreateQuizViewModel
    {
        [Required]
        [Display(Name = "Quiz name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Maximum number of teams allowed")]
        public int MaxTeams { get { return 5; } set { } }

        [Required]
        [Display(Name = "The time the event starts")]
        public DateTime StartTime
        {
            get
            {
                return DateTime.Now.AddDays(1);
            }
            set
            {
            }
        }

        public CreateQuizViewModel()
        {
        }

        public CreateQuizViewModel(string name, int maxTeams, DateTime startTime)
        {
            Name = name;
            MaxTeams = maxTeams;
            StartTime = startTime;
        }
    }
}