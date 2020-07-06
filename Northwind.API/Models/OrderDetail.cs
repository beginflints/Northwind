using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Northwind.API.Models
{
    [Table("OrderDetails")]
    public class OrderDetail
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int UnitPrice { get; set; }
        public int Quantity { get; set; }
        [Column(TypeName="decimal(18,4)")]
        public double Discount { get; set; }
    }
}