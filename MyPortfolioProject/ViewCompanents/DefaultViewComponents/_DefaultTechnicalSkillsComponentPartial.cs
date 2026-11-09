using Microsoft.AspNetCore.Mvc;
using MyPortfolioProject.Context;

namespace MyPortfolioProject.ViewCompanents.DefaultViewComponents
{
    public class _DefaultTechnicalSkillsComponentPartial : ViewComponent
    {
        private readonly PortfolioContext _context;

        public _DefaultTechnicalSkillsComponentPartial(PortfolioContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.TechnicalSkills.ToList();
            return View(values);
        }

    }
}
