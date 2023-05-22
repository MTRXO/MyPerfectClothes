using Microsoft.AspNetCore.Mvc;

namespace MyPerfectClothes.Controllers
{
    public class CartPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
