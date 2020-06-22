using Microsoft.EntityFrameworkCore;

namespace Northwind.API.Persistence
{
    public class NorthwindDbContext : DbContext
    {
        public NorthwindDbContext(DbContextOptions<NorthwindDbContext> options) 
        : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // modelBuilder.Entity<Customer>().Property<DateTime>("UpdateDate");
            // modelBuilder.Entity<Customer>().Property<DateTime>("CreateDate");
            // modelBuilder.Entity<Order>().Property<DateTime>("CreateDate");
            // modelBuilder.Entity<Order>().Property<DateTime>("UpdateDate");
        }

        // public DbSet<Make> Makes { get; set; }
        // public DbSet<Model> Models { get; set; }
        // public DbSet<Customer> Customers { get; set; }
        // public DbSet<Order> Orders { get; set; }
        // public DbSet<Product> Products { get; set; }
    }
}