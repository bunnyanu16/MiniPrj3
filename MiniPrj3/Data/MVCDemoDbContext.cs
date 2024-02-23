using Microsoft.EntityFrameworkCore;
using MiniPrj3.Models.Domain;

namespace MiniPrj3.Data
{
    public class MVCDemoDbContext : DbContext
    {
        public MVCDemoDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
