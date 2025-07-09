using Microsoft.EntityFrameworkCore;
using Lab05.Models;

namespace Lab05.Data
{
    public class DealsFinderDbContext : DbContext
    {
        //constructor
        public DealsFinderDbContext(DbContextOptions<DealsFinderDbContext> options)
            : base(options)
        {
        }

        // DbSets
        public DbSet<Customer> Customers { get; set; }
        public DbSet<FoodDeliveryService> FoodDeliveryServices { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Customer>().ToTable("Customer");
            modelBuilder.Entity<FoodDeliveryService>().ToTable("FoodDeliveryService");
            modelBuilder.Entity<Subscription>().ToTable("Subscription");

            
            modelBuilder.Entity<Subscription>()
                .HasKey(s => new { s.CustomerId, s.ServiceId });
        }
    }
}
