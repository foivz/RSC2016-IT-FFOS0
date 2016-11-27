using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Models.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HackathonVZ.ViewModels.Home
{
    public class IndexHomeViewModel
    {
        [Required]
        [Remote("TeamExists", "Shop", HttpMethod = "POST", ErrorMessage = "No team with this name exists or is full")]
        public string TeamName { get; set; }

        public List<Quiz> QuizList { get; set; }
        public List<Team> TeamList { get; set; }

        public IndexHomeViewModel()
        {
        }
    }
}