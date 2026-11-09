using Microsoft.AspNetCore.Mvc;
using MyPortfolioProject.Context;

namespace MyPortfolioProject.ViewCompanents.DefaultViewComponents
{
    public class _DefaultProfilComponentPartial : ViewComponent
    {
        private readonly PortfolioContext _context;

        public _DefaultProfilComponentPartial(PortfolioContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var values = _context.Profiles.FirstOrDefault();
            return View(values); // gelen ilk değeri modele gönderiyor 
        }
    }
}
