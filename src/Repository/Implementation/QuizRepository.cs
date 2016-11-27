using AutoMapper;
using HackathonVZ.Data;
using Microsoft.EntityFrameworkCore;
using Models.Models;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository.Implementation
{
    public class QuizRepository : IQuizRepository
    {
        private ApplicationDbContext _context;

        public QuizRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<long?> AddNewQuizAsync(string name, int maxTeams, DateTime startTime)
        {
            var quiz = new DAL.Models.Quiz
            {
                Name = name,
                MaxTeams = maxTeams,
                StartTime = startTime
            };

            await _context.Quiz.AddAsync(quiz);

            var saveResult = await _context.SaveChangesAsync();
            if (saveResult > 0)
            {
                return quiz.Id;
            }
            return null;
        }

        public async Task<bool> AddNewRoundAsync(long quizId, int numberOfQuestions, long categoryId, long typeId)
        {
            var newRound = new DAL.Models.QuizRound
            {
                QuizId = quizId,
                NumberOfQuestions = numberOfQuestions,
                CategoryId = categoryId,
                TypeId = typeId
            };

            await _context.QuizRound.AddAsync(newRound);

            var saveResult = await _context.SaveChangesAsync();
            if (saveResult > 0)
            {
                var questions = await _context.Question.Where(q => q.CategoryId == categoryId && q.TypeId == typeId).OrderBy(x => Guid.NewGuid()).Take(numberOfQuestions).ToListAsync();

                foreach (var question in questions)
                {
                    var roundQuestion = new DAL.Models.RoundQuestion
                    {
                        QuestionId = question.Id,
                        RoundId = newRound.Id
                    };
                    await _context.RoundQuestion.AddAsync(roundQuestion);
                }
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<List<RoundQuestion>> GetAllRoundQuestionsAsync(long roundId)
        {
            var roundQuestions = await _context.RoundQuestion.Where(rq => rq.RoundId == roundId).ToListAsync();
            return Mapper.Map<List<RoundQuestion>>(roundQuestions);
        }

        public async Task<Quiz> GetQuizByIdAsync(long quizId)
        {
            var quiz = await _context.Quiz.Where(q => q.Id == quizId).FirstOrDefaultAsync();
            return Mapper.Map<Quiz>(quiz);
        }

        public async Task<List<QuizRound>> GetQuizRoundsByQuizIdAsync(long quizId)
        {
            var quizRounds = await _context.QuizRound.Where(qr => qr.QuizId == quizId).ToListAsync();
            return Mapper.Map<List<QuizRound>>(quizRounds);
        }

        public async Task<bool> UpdateRoundAsync(long categoryId, long typeId, long roundId)
        {
            var round = await _context.QuizRound.Where(qr => qr.Id == roundId).FirstOrDefaultAsync();
            var roundQuestions = await _context.RoundQuestion.Where(rq => rq.RoundId == roundId).ToListAsync();

            _context.QuizRound.Attach(round);
            round.CategoryId = categoryId;
            round.TypeId = typeId;
            _context.Entry(round).State = EntityState.Modified;

            _context.RoundQuestion.RemoveRange(roundQuestions);

            var questions = await _context.Question.Where(q => q.CategoryId == categoryId && q.TypeId == typeId).OrderBy(x => Guid.NewGuid()).Take(round.NumberOfQuestions == 0 ? 5 : round.NumberOfQuestions).ToListAsync();

            foreach (var question in questions)
            {
                var roundQuestion = new DAL.Models.RoundQuestion
                {
                    QuestionId = question.Id,
                    RoundId = roundId
                };
                await _context.RoundQuestion.AddAsync(roundQuestion);
            }

            var saveResult = await _context.SaveChangesAsync();
            if (saveResult > 0)
            {
                return true;
            }
            return false;
        }

        public async Task<List<Quiz>> GetAllQuizesAsync()
        {
            var quizes = await _context.Quiz.ToListAsync();
            return Mapper.Map<List<Quiz>>(quizes);
        }
    }
}