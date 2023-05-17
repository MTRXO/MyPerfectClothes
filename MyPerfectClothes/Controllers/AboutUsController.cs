using Microsoft.AspNetCore.Mvc;

namespace MyPerfectClothes.Controllers
{
    public class AboutUsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
