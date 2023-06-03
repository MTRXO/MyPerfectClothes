using Microsoft.AspNetCore.Mvc;

namespace MyPerfectClothes.Controllers
{
    public class AllOrdersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
