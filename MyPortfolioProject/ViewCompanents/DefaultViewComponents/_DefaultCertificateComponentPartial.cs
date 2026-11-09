using Microsoft.AspNetCore.Mvc;
using MyPortfolioProject.Context;

namespace MyPortfolioProject.ViewCompanents.DefaultViewComponents
{
    public class _DefaultCertificateComponentPartial:ViewComponent
    {
        private readonly PortfolioContext _context;

        public _DefaultCertificateComponentPartial(PortfolioContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var values =_context.Certificates.ToList();
            return View(values);
        }
    }
}
