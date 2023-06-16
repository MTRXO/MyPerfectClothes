using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MyPerfectClothes.Models;
using System.Net;

namespace MyPerfectClothes.Controllers
{
    public class CartPageController : Controller
    {
        CurrentCartState CartRn = new CurrentCartState();
       //public bool IsClicked = false;
        public IActionResult Index()
        {
            CartRn.Name = "Shoes";
            CartRn.Price = 20;
            ViewBag.NameOfProduct = CartRn.Name;
            ViewBag.PriceOfProduct = CartRn.Price;
            //IsClicked = true;
            return View();
         
        }
       
    }
}
