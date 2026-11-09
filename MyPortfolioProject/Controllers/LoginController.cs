using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyPortfolioProject.Context;
using System.Security.Claims;

namespace MyPortfolioProject.Controllers
{
    [AllowAnonymous] // Giriş yapmamış herkes bu sayfaya erişebilir
    public class LoginController : Controller
    {
        private readonly PortfolioContext _context;

        public LoginController(PortfolioContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(Entities.Setting p)
        {
            // Ayarlar tablosundaki Username ve Password ile formdan gelenleri karşılaştırıyoruz
            var user = _context.Settings.FirstOrDefault(x => x.Username == p.Username && x.Password == p.Password);

            if (user != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.Username)
                };

                var userIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var principal = new ClaimsPrincipal(userIdentity);

                await HttpContext.SignInAsync(principal);

                // Giriş başarılı ise Admin Dashboard'a yönlendir
                return RedirectToAction("Index", "Dashboard", new { area = "Admin" });
            }

            ModelState.AddModelError("", "Kullanıcı adı veya şifre hatalı.");
            return View();
        }

        // Çıkış Yap (Logout) İşlemi
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Login");
        }
    }
}