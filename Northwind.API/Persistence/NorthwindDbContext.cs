using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;
using Northwind.API.Models;

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
            modelBuilder.Entity<OrderDetail>().HasKey(o => new { o.OrderId, o.ProductId });
            
            // var entityTypes = db.Model.GetEntityTypes().Select(t => t.ClrType).ToList();
            // modelBuilder.Entity<Customer>().Property<DateTime>("UpdateDate");
            // modelBuilder.Entity<Customer>().Property<DateTime>("CreateDate");
            // modelBuilder.Entity<Order>().Property<DateTime>("CreateDate");
            // modelBuilder.Entity<Order>().Property<DateTime>("UpdateDate");
        }


        public DbSet<Category> Category { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Region> Region { get; set; }
        public DbSet<Shipper> Shipper { get; set; }
        public DbSet<Supplier> Supplier { get; set; }
        public DbSet<Territory> Territory { get; set; }
    }
}