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
            // modelBuilder.Entity<Customer>().Property<DateTime>("UpdateDate");
            // modelBuilder.Entity<Customer>().Property<DateTime>("CreateDate");
            // modelBuilder.Entity<Order>().Property<DateTime>("CreateDate");
            // modelBuilder.Entity<Order>().Property<DateTime>("UpdateDate");
        }
        public DbSet<Category> Category { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Employee> Employee { get; set; }
        // public DbSet<Order> Order { get; set; }
        // public DbSet<OrderDetail> OrderDetail { get; set; }
        // public DbSet<Product> Products { get; set; }
        public DbSet<Region> Region { get; set; }
        // public DbSet<Shipper> Shipper { get; set; }
        public DbSet<Supplier> Supplier { get; set; }
        // public DbSet<Territory> Territory { get; set; }

        // public DbSet<Make> Makes { get; set; }
        // public DbSet<Model> Models { get; set; }
        // public DbSet<Customer> Customers { get; set; }
        // public DbSet<Order> Orders { get; set; }
        // public DbSet<Product> Products { get; set; }
    }
}