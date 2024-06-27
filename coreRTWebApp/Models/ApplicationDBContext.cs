using Microsoft.EntityFrameworkCore;

namespace coreRTWebApp.Models
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<ShopItem> ShopItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=RenovatioAdmin;Database=RTechDB;Integrated Security=true;TrustServerCertificate=true;");
        }
    }
}
