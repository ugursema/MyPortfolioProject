using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyPortfolioProject.Context;
using MyPortfolioProject.Entities;

namespace MyPortfolioProject.Areas.Admin.Controllers
{// Bu controller'ın bir Admin alanına (Area) ait olduğunu belirtir
    [Area("Admin")]
    [Authorize]
    public class ExperienceController : Controller
    {
        // Veritabanı işlemlerini yapabilmek için tanımlanan salt okunur (read-only) field
        private readonly PortfolioContext _context;

        // Constructor (Yapıcı Metot): Dependency Injection ile context nesnesini içeri alıyoruz
        public ExperienceController(PortfolioContext context)
        {
            _context = context;
        }

        // Deneyimler listesini ekrana getiren aksiyon metodu
        public IActionResult ExperienceList()
        {
            // Veritabanındaki Experience tablosundaki tüm verileri liste olarak çekip değişkene atıyoruz
            var values = _context.Experiences.ToList();

            // Çekilen bu verileri (somut nesneyi/listeyi) arayüze (View) model olarak taşıyoruz
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateExperience()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateExperience(Experience experience )
        {
            _context.Experiences.Add(experience);
            _context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }


        public IActionResult DeleteExperience(int id)
        {
            var value = _context.Experiences.Find(id);
            _context.Experiences.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }

        [HttpGet]
        public IActionResult UpdateExperience(int id)
        {
            var value = _context.Experiences.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateExperience(Experience experience)
        {
            _context.Experiences.Update(experience);
            _context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }
    }
}