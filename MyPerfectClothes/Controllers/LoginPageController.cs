using Microsoft.AspNetCore.Mvc;

namespace MyPerfectClothes.Controllers
{
    public class LoginPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
