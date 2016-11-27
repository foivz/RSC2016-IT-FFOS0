using HackathonVZ.ViewModels.Admin;
using Microsoft.AspNetCore.Mvc;
using Service.Interface;
using System.Threading.Tasks;

namespace HackathonVZ.Controllers
{
    public class AdminController : Controller
    {
        private IQuizService _quizService;
        private ILookupService _lookupService;

        public AdminController(
            IQuizService quizService,
            ILookupService lookupService
            )
        {
            _quizService = quizService;
            _lookupService = lookupService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("CreateQuiz")]
        public IActionResult CreateQuiz()
        {
            var viewModel = new CreateQuizViewModel();
            return View(viewModel);
        }

        [HttpPost]
        [Route("CreateQuiz")]
        public async Task<IActionResult> CreateQuiz(CreateQuizViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var createQuiz = await _quizService.AddNewQuizAsync(viewModel.Name, viewModel.MaxTeams, viewModel.StartTime);
                if (createQuiz != null)
                {
                    return RedirectToAction("Rounds", new { quizId = createQuiz });
                }
            }

            return View(viewModel);
        }

        [HttpGet]
        [Route("Rounds/{quizId}")]
        public async Task<IActionResult> Rounds(long quizId)
        {
            var quiz = await _quizService.GetQuizByIdAsync(quizId);
            var categories = await _lookupService.GetAllCategoriesAsync();
            var questionTypes = await _lookupService.GetAllQuestionTypesAsync();

            var viewModel = new RoundsViewModel(quiz, categories, questionTypes);
            return View(viewModel);
        }

        public async Task<IActionResult> UpdateRound(long categoryId, long typeId, long roundId, long quizId)
        {
            var update = await _quizService.UpdateRoundAsync(categoryId, typeId, roundId);
            if (update == true)
            {
                return RedirectToAction("RoundsPartial", new { quizId = quizId });
            }
            return null;
        }

        public async Task<IActionResult> AddRound(long quizId, int numberOfQuestions, long categoryId, long typeId)
        {
            var addRound = await _quizService.AddNewRoundAsync(quizId, numberOfQuestions, categoryId, typeId);
            return RedirectToAction("RoundsPartial", new { quizId = quizId });
        }

        public async Task<IActionResult> RoundsPartial(long quizId)
        {
            var viewModel = new RoundsPartialViewModel();
            var quiz = await _quizService.GetQuizByIdAsync(quizId);
            var rounds = await _quizService.GetQuizRoundsByQuizIdAsync(quizId);
            var categories = await _lookupService.GetAllCategoriesAsync();
            var modifiers = await _lookupService.GetAllModifiersAsync();
            var questionTypes = await _lookupService.GetAllQuestionTypesAsync();

            viewModel.Quiz = quiz;
            viewModel.Rounds = rounds;
            viewModel.Categories = categories;
            viewModel.QuestionTypes = questionTypes;
            viewModel.Modifiers = modifiers;

            return PartialView("~/Views/Admin/Partials/_RoundsPartial.cshtml", viewModel);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}