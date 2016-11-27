using HackathonVZ.Data;
using HackathonVZ.ViewModels.Home;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Service.Interface;
using System.Threading.Tasks;

namespace HackathonVZ.Controllers
{
    public class HomeController : Controller
    {
        private UserManager<ApplicationUser> _userManager;
        private IUserService _userService;
        private IQuizService _quizService;

        public HomeController(UserManager<ApplicationUser> userManager,
            IUserService userService,
            IQuizService quizService)
        {
            _userManager = userManager;
            _userService = userService;
            _quizService = quizService;
        }

        public async Task<IActionResult> Index(string message)
        {
            var viewModel = new IndexHomeViewModel();

            viewModel.QuizList = await _quizService.GetAllQuizesAsync();
            viewModel.TeamList = await _userService.GetAllTeamsAsync();

            ViewData["Message"] = message == null ? null : message;
            return View(viewModel);
        }

        public IActionResult MainGame()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        public async Task<ActionResult> TeamExists([Bind(Prefix = "TeamName")]string teamName)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var team = await _userService.FindTeamByNameAsync(teamName);
            if (team != null)
            {
                var teamMemberCount = await _userService.GetTeamMemberCount(team.Id);
                if (teamMemberCount < 3) await _userService.JoinTeamAsync(team.Id, user.Id);
                return RedirectToAction("Index", new { message = "Successfully joined team." });
            }
            return RedirectToAction("Index", new { message = "Team does not exist or is full." });
        }
    }
}