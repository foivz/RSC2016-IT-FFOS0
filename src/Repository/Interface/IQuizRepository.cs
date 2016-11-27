using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository.Interface
{
    public interface IQuizRepository
    {
        Task<long?> AddNewQuizAsync(string name, int maxTeams, DateTime startTime);

        Task<Quiz> GetQuizByIdAsync(long quizId);

        Task<List<QuizRound>> GetQuizRoundsByQuizIdAsync(long quizId);

        Task<bool> UpdateRoundAsync(long categoryId, long typeId, long roundId);

        Task<List<RoundQuestion>> GetAllRoundQuestionsAsync(long roundId);

        Task<bool> AddNewRoundAsync(long quizId, int numberOfQuestions, long categoryId, long typeId);

        Task<List<Quiz>> GetAllQuizesAsync();
    }
}