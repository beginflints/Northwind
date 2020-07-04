using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using DatingApp.API.Models;

namespace Northwind.API.Models
{
    [Table("Products")]
    public class Product
    {
        public int ProductID { get; set; }
        [NotNull]
        public string ProductName { get; set; }
        public Supplier Supplier { get; set; }
        public Category Category { get; set; }
        public string QuantityPerUnit { get; set; }
        [Column(TypeName="money")]
        public decimal UnitPrice { get; set; }
        public int UnitInStock { get; set; }
        public int ReOrderLevel { get; set; }
        public bool Discontinued { get; set; }
    }
}