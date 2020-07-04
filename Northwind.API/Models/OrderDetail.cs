using System.ComponentModel.DataAnnotations.Schema;

namespace Northwind.API.Models
{
    [Table("OrderDetails")]
    public class OrderDetail
    {
        public int OrderID { get; set; }
        public Product Product { get; set; }
        public int UnitPrice { get; set; }
        public int Quantity { get; set; }
        public float Discount { get; set; }
    }
}