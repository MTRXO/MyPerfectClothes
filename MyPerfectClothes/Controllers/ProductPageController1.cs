using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNetCore.Mvc.Rendering;
using MyPerfectClothes.Models;


namespace MyPerfectClothes.Controllers
{
    public class ProductPageController1 : Controller
    {
        
        public IActionResult Index()
        {
            List<int> Size = new List<int>
            {
                37,38,39,40,41,42
            }.ToList();
            
            List<string> Colors = new List<string>
            {
              "Red","Blue","White","Orange","Black"
            }.ToList();

            ViewBag.Size = Size;
            ViewBag.Colors = Colors;


            return View();
        }
    }
}
