using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioProject.ViewCompanents.DefaultViewComponents
{
    public class _DefaultStyleComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
