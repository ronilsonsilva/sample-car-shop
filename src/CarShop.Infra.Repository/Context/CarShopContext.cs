using CarShop.Infra.Data.Context.Map;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CarShop.Infra.Data.Context
{
    public class CarShopContext : DbContext
    {
        public CarShopContext() 
        {
        }

        public CarShopContext(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connection = "Server=localhost,1433;Database=car_shop;User Id=sa;Password=Sig@2022;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False;Connection Timeout=30;";
            optionsBuilder.UseSqlServer(connection);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CarMap());
            modelBuilder.ApplyConfiguration(new CustomerMap());
            modelBuilder.ApplyConfiguration(new OrderMap());
            modelBuilder.ApplyConfiguration(new OrderDetailsMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
