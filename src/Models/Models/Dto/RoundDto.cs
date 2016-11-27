using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models.Models.Dto
{
    public class RoundDto
    {
        public QuizRound Round { get; set; }
        public List<RoundQuestion> RoundQuestions { get; set; }

        public RoundDto(QuizRound round, List<RoundQuestion> roundQuestion)
        {
            Round = round;
            RoundQuestions = roundQuestion;
        }
    }
}