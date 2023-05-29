using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MyPerfectClothes.Models;

namespace MyPerfectClothes.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {

        }

        
        public DbSet<OrderProperties> OrderProp  { get; set; }
    }
}
