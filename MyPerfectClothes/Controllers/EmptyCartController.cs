using Microsoft.AspNetCore.Mvc;
using MyPerfectClothes.Models;

namespace MyPerfectClothes.Controllers
{
    public class EmptyCartController : Controller
    {
        public IActionResult Index()
        {
        
            return View("~/Views/CartPage/Index.cshtml");
        }
    }
}
