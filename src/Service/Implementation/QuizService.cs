using Models.Models;
using Models.Models.Dto;
using Repository.Interface;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Service.Implementation
{
    public class QuizService : IQuizService
    {
        private IQuizRepository _quizRepository;

        public QuizService(
            IQuizRepository quizRepository
            )
        {
            _quizRepository = quizRepository;
        }

        public async Task<long?> AddNewQuizAsync(string name, int maxTeams, DateTime startTime)
        {
            return await _quizRepository.AddNewQuizAsync(name, maxTeams, startTime);
        }

        public async Task<bool> AddNewRoundAsync(long quizId, int numberOfQuestions, long categoryId, long typeId)
        {
            return await _quizRepository.AddNewRoundAsync(quizId, numberOfQuestions, categoryId, typeId);
        }

        public async Task<List<RoundQuestion>> GetAllRoundQuestionsAsync(long roundId)
        {
            return await _quizRepository.GetAllRoundQuestionsAsync(roundId);
        }

        public async Task<Quiz> GetQuizByIdAsync(long quizId)
        {
            return await _quizRepository.GetQuizByIdAsync(quizId);
        }

        public async Task<List<RoundDto>> GetQuizRoundsByQuizIdAsync(long quizId)
        {
            var allRoundDtos = new List<RoundDto>();
            var rounds = await _quizRepository.GetQuizRoundsByQuizIdAsync(quizId);
            foreach (var round in rounds)
            {
                var roundQuestions = await _quizRepository.GetAllRoundQuestionsAsync(round.Id);
                var roundDto = new RoundDto(round, roundQuestions);

                allRoundDtos.Add(roundDto);
            }
            return allRoundDtos;
        }

        public async Task<bool> UpdateRoundAsync(long categoryId, long typeId, long roundId)
        {
            return await _quizRepository.UpdateRoundAsync(categoryId, typeId, roundId);
        }

        public async Task<List<Quiz>> GetAllQuizesAsync()
        {
            return await _quizRepository.GetAllQuizesAsync();
        }
    }
}