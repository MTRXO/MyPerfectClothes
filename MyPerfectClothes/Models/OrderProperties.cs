using MessagePack;
using Microsoft.Build.Framework;
using Microsoft.EntityFrameworkCore;

namespace MyPerfectClothes.Models
{
    [Keyless]
    public class OrderProperties
    {
   
        public string  ClothesType { get; set; }
        public double Price { get; set; }
        public int Size { get; set; }
        public string Color { get; set; }

    }
}
