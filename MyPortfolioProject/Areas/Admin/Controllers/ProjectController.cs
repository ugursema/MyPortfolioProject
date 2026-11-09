using AspNetCoreGeneratedDocument;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyPortfolioProject.Context;
using MyPortfolioProject.Entities;

namespace MyPortfolioProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class ProjectController : Controller
    {
        

        private readonly PortfolioContext _context;

        public ProjectController(PortfolioContext context)
        {
            _context = context;
        }

        public IActionResult ProjectList()
        {
            var values = _context.Projects.Include(x => x.Category).ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateProject()
        {
            // Kategorileri veritabanından çekip SelectList ile ViewBag'e aktarıyoruz
            var categories = _context.Categories.ToList();
            ViewBag.v = new SelectList(categories, "CategoryId", "CategoryName");
            return View();
        }
        [HttpPost]
        public IActionResult CreateProject(Project project)
        {
            _context.Projects.Add(project);
            _context.SaveChanges();
            return RedirectToAction("ProjectList");
        }

        public IActionResult DeleteProject(int id)
        {
            var value= _context.Projects.Find(id);
            _context.Projects.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("ProjectList");
        }

       
        [HttpGet]
        public IActionResult UpdateProject(int id)
        {
            var value = _context.Projects.Find(id);

            // Güncelleme sayfasında dropdown'ın dolu ve seçili gelmesi için
            var categories = _context.Categories.ToList();
            ViewBag.v = new SelectList(categories, "CategoryId", "CategoryName", value.CategoryId);

            return View(value);
        }
        [HttpPost]

        public IActionResult UpdateProject(Project project)
        {
            _context.Projects.Update(project);
            _context.SaveChanges();
            return RedirectToAction("ProjectList");
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
