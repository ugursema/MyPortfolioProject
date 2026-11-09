using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioProject.ViewCompanents.DefaultViewComponents
{
    public class _DefaultHeadComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
