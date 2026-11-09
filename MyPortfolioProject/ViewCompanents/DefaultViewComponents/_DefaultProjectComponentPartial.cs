using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyPortfolioProject.Context;

namespace MyPortfolioProject.ViewCompanents.DefaultViewComponents
{
    public class _DefaultProjectComponentPartial : ViewComponent
    {
        private readonly PortfolioContext _context;

        public _DefaultProjectComponentPartial(PortfolioContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            //var values = _context.Projects.ToList();
            var values = _context.Projects.Include(x => x.Category).ToList();
            return View(values);
        }
    }
}
