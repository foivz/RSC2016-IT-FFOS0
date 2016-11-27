using Models.Models;
using Models.Models.Dto;
using Models.Models.Lookup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackathonVZ.ViewModels.Admin
{
    public class RoundsPartialViewModel
    {
        public Quiz Quiz { get; set; }
        public List<RoundDto> Rounds { get; set; }
        public List<Category> Categories { get; set; }
        public List<QuestionType> QuestionTypes { get; set; }
        public List<Modifier> Modifiers { get; set; }

        public RoundsPartialViewModel()
        {
        }

        public RoundsPartialViewModel(
            List<RoundDto> rounds,
            List<Category> categories,
            List<QuestionType> questionTypes,
            List<Modifier> modifiers
            )
        {
            Rounds = rounds;
            Categories = categories;
            QuestionTypes = questionTypes;
            Modifiers = modifiers;
        }
    }
}