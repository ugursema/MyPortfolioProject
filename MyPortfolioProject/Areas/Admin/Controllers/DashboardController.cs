using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyPortfolioProject.Context;
using MyPortfolioProject.Models;

namespace MyPortfolioProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class DashboardController : Controller
    {
        private readonly PortfolioContext _context;

        public DashboardController(PortfolioContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var model = new DashboardViewModel
            {
                TotalProjectCount = _context.Projects.Count(),
                TotalSkillCount = _context.Experiences.Count(),
                TotalMessageCount = _context.Messages.Count(),
                UnreadMessageCount = _context.Messages.Count(x => !x.IsRead),
                LastProjects = _context.Projects.Include(x => x.Category).OrderByDescending(x => x.ProjectId).Take(5).ToList()
            };

            // Eğer istersen ViewBag ile de ek veriler taşıyabilirsin:
            ViewBag.totalMessage = _context.Messages.Count();
            ViewBag.readMessage = _context.Messages.Where(x => x.IsRead == true).Count();
            ViewBag.unreadMessage = _context.Messages.Where(y => y.IsRead == false).Count();
            ViewBag.LastProjects = _context.Projects.Include(x => x.Category).OrderByDescending(x => x.ProjectId).Take(5).ToList();
            ViewBag.SkillList = _context.Experiences.OrderByDescending(x => x.ExperienceId).Take(5).ToList();
            // Modeli view'a gönderiyoruz:
            return View(model);
        }
    }
}