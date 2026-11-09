//using Microsoft.AspNetCore.Mvc;
//using MyPortfolioProject.Context;
//using MyPortfolioProject.Entities;

//namespace MyPortfolioProject.Controllers
//{
//    public class DefaultController : Controller
//    {
//        private readonly PortfolioContext _context;

//        public DefaultController(PortfolioContext context)
//        {
//            _context = context;
//        }

//        public IActionResult Index()
//        {
//            return View();
//        }

//        [HttpPost]
//        public IActionResult SendMessage(Message message)
//        {
//            message.SendDate = DateTime.Now;
//            message.IsRead = false;

//            _context.Messages.Add(message);
//            _context.SaveChanges();

//            return RedirectToAction("Index", "Default");
//        }
//    }
//}
using Microsoft.AspNetCore.Mvc;
using MyPortfolioProject.Context; // Kendi namespace'ine göre kontrol edebilirsin
using MyPortfolioProject.Context;
using MyPortfolioProject.Entities;

namespace MyPortfolioProject.Controllers
{
    public class DefaultController : Controller
    {
        private readonly PortfolioContext _context;
        private readonly IWebHostEnvironment _environment;

        // Constructor içinde hem PortfolioContext hem de IWebHostEnvironment'ı birlikte alıyoruz
        public DefaultController(PortfolioContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SendMessage(Message message)
        {
            message.SendDate = DateTime.Now;
            message.IsRead = false;

            _context.Messages.Add(message);
            _context.SaveChanges();

            return RedirectToAction("Index", "Default");
        }

        // --- CV İNDİRME METODU ---
        [HttpGet]
        public IActionResult DownloadCv()
        {
            string path = Path.Combine(_environment.WebRootPath, "files", "sema-ugur-cv.pdf");

            if (!System.IO.File.Exists(path))
            {
                return NotFound(); // Dosya bulunamazsa 404 döner
            }

            byte[] fileBytes = System.IO.File.ReadAllBytes(path);

            return File(fileBytes, "application/pdf", "Sema_Ugur_CV.pdf");
        }
    }
}