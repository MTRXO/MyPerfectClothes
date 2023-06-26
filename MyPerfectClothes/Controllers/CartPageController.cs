using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Net;
using MyPerfectClothes.Models.OrderReady;

namespace MyPerfectClothes.Controllers
{
    public class CartPageController : Controller
    {
        CurrentCartState CartRn = new CurrentCartState();
     
        public IActionResult Index()
        {
            CartRn.Name = "Shoes";
            CartRn.Price = 50;
            CartRn.IsEmpty = false;
            ViewBag.NameOfProduct = CartRn.Name;
            ViewBag.PriceOfProduct = CartRn.Price;
            ViewBag.IsCartEmpty = CartRn.IsEmpty;

           


            return View();
         
        }
       
    }
}
