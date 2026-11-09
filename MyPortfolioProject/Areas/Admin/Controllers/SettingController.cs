using Microsoft.AspNetCore.Mvc;
using MyPortfolioProject.Context;
using MyPortfolioProject.Entities;

namespace MyPortfolioProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SettingController : Controller
    {
        private readonly PortfolioContext _context;

        public SettingController(PortfolioContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            // Veritabanındaki ilk ve tek ayar kaydını getiriyoruz
            var value = _context.Settings.FirstOrDefault();
            return View(value);
        }

        [HttpPost]
        public IActionResult Index(Setting setting)
        {
            _context.Settings.Update(setting);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}