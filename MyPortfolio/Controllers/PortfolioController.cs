using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Services;

namespace MyPortfolio.Controllers
{
    [Authorize]
    public class PortfolioController : Controller
    {
        private readonly PortfolioService _portfolioService;

        public PortfolioController(PortfolioService portfolioService)
        {
            _portfolioService = portfolioService;
        }

        public IActionResult Index()
        {
            var projects = _portfolioService.GetAllProjects();
            return View(projects);
        }

        public IActionResult Details(int id)
        {
            var project = _portfolioService.GetProjectById(id);
            if (project == null) return NotFound();
            return View(project);
        }


        [HttpPost]
        public IActionResult AddComment(int projectId, string commentText)
        {
            _portfolioService.AddComment(projectId, commentText);
            return RedirectToAction("Details", new { id = projectId });
        }
    }
}