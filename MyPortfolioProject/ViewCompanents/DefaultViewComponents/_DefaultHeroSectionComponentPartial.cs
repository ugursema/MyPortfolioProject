using Microsoft.AspNetCore.Mvc;
using MyPortfolioProject.Context;

namespace MyPortfolioProject.ViewCompanents.DefaultViewComponents
{
    public class _DefaultHeroSectionComponentPartial:ViewComponent
    {
        private readonly PortfolioContext _context;

        public _DefaultHeroSectionComponentPartial(PortfolioContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            // Veritabanındaki HeroSection tablosundaki ilk kaydı getiriyor
            var values = _context.HeroSections.FirstOrDefault();

            // Hero alanındaki başlık verisini ViewBag ile arayüze (View) aktarıyor
            ViewBag.v1 = values.Title;

            // Hero alanındaki alt başlık verisini ViewBag ile arayüze aktarıyor
            ViewBag.v2 = values.SubTitle;

            // Hero alanındaki açıklama metnini ViewBag ile arayüze aktarıyor
            ViewBag.v3 = values.Description;

            // Hero alanında gösterilecek görselin dosya yolunu/linkini ViewBag ile arayüze aktarıyor
            ViewBag.v4 = values.ImageUrl;

            // View Component'in bağlı olduğu Razor view dosyasını ekrana (default olarak ilgili klasördeki Default.cshtml) yansıtıyor
            return View();
        }
    }
}
