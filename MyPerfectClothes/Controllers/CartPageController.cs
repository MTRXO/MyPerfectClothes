using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MyPerfectClothes.Models;
using System.Net;

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
