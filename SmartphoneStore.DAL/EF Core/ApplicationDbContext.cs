using Microsoft.EntityFrameworkCore;
using SmartphoneStore.DAL.Entities;

namespace SmartphoneStore.DAL.EF_Core
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
