using Microsoft.AspNetCore.Mvc;
using MyPortfolioProject.Context;

namespace MyPortfolioProject.ViewCompanents.DefaultViewComponents
{
    public class _DefaultAboutRigthComponentPartial:ViewComponent
    {
        private readonly PortfolioContext _context;

        public _DefaultAboutRigthComponentPartial(PortfolioContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.AboutRights.ToList();
            return View(values);
        }
    }
}
