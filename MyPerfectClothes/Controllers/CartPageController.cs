using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Net;
using MyPerfectClothes.Models;

namespace MyPerfectClothes.Controllers
{
    public class CartPageController : Controller
    {
        OrderProperties OrderValue = new OrderProperties();
     
        public IActionResult Index()
        {

            OrderValue.ClothesType = "Shoes";
            OrderValue.Price = 12;
            ViewBag.Cloth = OrderValue.ClothesType;
            ViewBag.Price = OrderValue.Price;


            return View();
         
        }
       
    }
}
