using Microsoft.AspNetCore.Mvc;
using MyPerfectClothes.Data;

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
            var objCategoryList = _db.OrderProp.ToList();
            return View();
        }

    }
}
