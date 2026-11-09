using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyPortfolioProject.Context;
using MyPortfolioProject.Entities;

namespace MyPortfolioProject.Controllers
{
    [Area("Admin")]
    public class AdminProfileController : Controller
    {
        private readonly PortfolioContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment; // wwwroot klasörüne erişmek için

        public AdminProfileController(PortfolioContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        [HttpGet]
        public IActionResult Index()
        {
            // Tek bir profil kaydı tutacağımız için ilk kaydı alıyoruz
            var value = _context.Profiles.FirstOrDefault();
            if (value == null)
            {
                value = new Profile(); // Eğer kayıt yoksa boş nesne gönder
            }
            return View(value);
        }

        [HttpPost]
        public async Task<IActionResult> Index(Profile profile, IFormFile imageFile)
        {
            // Eğer kullanıcı yeni bir dosya seçtiyse
            if (imageFile != null && imageFile.Length > 0)
            {
                // Benzersiz dosya adı oluşturma (GUID + uzantı)
                var extension = Path.GetExtension(imageFile.FileName);
                var fileName = Guid.NewGuid().ToString() + extension;
                var folderPath = Path.Combine(_webHostEnvironment.WebRootPath, "images/profile");

                // Klasör yoksa oluştur
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                var filePath = Path.Combine(folderPath, fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await imageFile.CopyToAsync(stream);
                }

                // Veritabanına kaydedilecek dosya yolu
                profile.ImageUrl = "/images/profile/" + fileName;
            }
            else
            {
                // Yeni fotoğraf seçilmediyse eski fotoğraf kaybolmasın diye mevcut veriyi koruyoruz
                var existingProfile = _context.Profiles.AsNoTracking().FirstOrDefault(x => x.ProfileId == profile.ProfileId);
                if (existingProfile != null)
                {
                    profile.ImageUrl = existingProfile.ImageUrl;
                }
            }

            if (profile.ProfileId == 0)
            {
                _context.Profiles.Add(profile);
            }
            else
            {
                _context.Profiles.Update(profile);
            }

            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}