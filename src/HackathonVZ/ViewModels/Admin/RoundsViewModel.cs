using Models.Models;
using Models.Models.Lookup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackathonVZ.ViewModels.Admin
{
    public class RoundsViewModel
    {
        public Quiz Quiz { get; set; }
        public List<Category> Categories { get; set; }
        public List<QuestionType> QuestionTypes { get; set; }

        public RoundsViewModel()
        {
        }

        public RoundsViewModel(Quiz quiz, List<Category> categories, List<QuestionType> questionTypes)
        {
            Quiz = quiz;
            Categories = categories;
            QuestionTypes = questionTypes;
        }
    }
}