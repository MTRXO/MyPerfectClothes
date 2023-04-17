using Microsoft.AspNetCore.Mvc;

namespace MyPerfectClothes.Controllers
{
    public class ProductPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
