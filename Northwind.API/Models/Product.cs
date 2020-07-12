using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using Northwind.API.Models;

namespace Northwind.API.Models
{
    [Table("Products")]
    public class Product
    {
        public int ProductId { get; set; }
        [NotNull]
        public string ProductName { get; set; }
        public Supplier Supplier { get; set; }
        public Category Category { get; set; }
        public string QuantityPerUnit { get; set; }
        [Column(TypeName="decimal(18,2)")]
        public double UnitPrice { get; set; }
        public int UnitInStock { get; set; }
        public int ReOrderLevel { get; set; }
        public bool Discontinued { get; set; }
    }
}