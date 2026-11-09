using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyPortfolioProject.Models;

namespace MyPortfolioProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //private readonly IWebHostEnvironment _environment;

        //public HomeController(IWebHostEnvironment environment)
        //{
        //    _environment = environment;
        //}

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;

        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        ////PDF ÝNDÝRME
        //[HttpGet]
        //public IActionResult DownloadCv()
        //{
        //    // wwwroot/files/sema-ugur-cv.pdf yolunu dinamik olarak birleþtirme
        //    string path = Path.Combine(_environment.WebRootPath, "files", "sema-ugur-cv.pdf");

        //    if (!System.IO.File.Exists(path))
        //    {
        //        return NotFound(); // Dosya yoksa 404 döndürüyor
        //    }

        //    byte[] fileBytes = System.IO.File.ReadAllBytes(path);

        //    // Dosyayý tarayýcýya indirilebilir olarak gönderiyor
        //    return File(fileBytes, "application/pdf", "Sema_Ugur_CV.pdf");
        //}
    }
}
