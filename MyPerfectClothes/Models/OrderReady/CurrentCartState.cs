using Microsoft.AspNetCore.Mvc;
using MyPerfectClothes.Controllers;

namespace MyPerfectClothes.Models.OrderReady
{

    public class CurrentCartState : ProductPageController1
    {
        public int Price { get; set; }
        public string Name { get; set; }
        public bool IsEmpty { get; set; }
        public int Size { get; set; }
        public string Color { get; set; }


    }
}
