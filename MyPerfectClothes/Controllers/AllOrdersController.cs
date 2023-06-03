using Microsoft.AspNetCore.Mvc;
using MyPerfectClothes.Data;
using MyPerfectClothes.Models;

namespace MyPerfectClothes.Controllers
{
    public class AllOrdersController : Controller
    {
        private readonly AppDbContext _db;
        public AllOrdersController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<OrderProperties> objCategoryList = _db.OrderProp;
            return View(objCategoryList);
        }

    }
}
