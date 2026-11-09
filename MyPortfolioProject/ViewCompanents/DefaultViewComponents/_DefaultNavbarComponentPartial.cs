using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioProject.ViewCompanents.DefaultViewComponents
{
    public class _DefaultNavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
