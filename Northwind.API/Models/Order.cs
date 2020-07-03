using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Northwind.API.Models
{
    [Table("Orders")]
    public class Order
    {
        public int OrderID { get; set; }
        [Required]
        public string CustomerID { get; set; }
        [Column(TypeName = "nvarchar(15)")]
        public string EmployeeID { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? RequiredDate { get; set; }
        public DateTime? ShippedDate { get; set; }
        public int ShipVia { get; set; }
        public decimal Freight { get; set; }
        [Column(TypeName = "nvarchar(40)")]
        public string ShipName { get; set; }
        [Column(TypeName = "nvarchar(60)")]
        public string ShipAddress { get; set; }
        [Column(TypeName = "nvarchar(15)")]
        public string ShipCity { get; set; }
        [Column(TypeName = "nvarchar(15)")]
        public string ShipRegion { get; set; }
        [Column(TypeName = "nvarchar(10)")]
        public string ShipPostalCode { get; set; }
        [Column(TypeName = "nvarchar(15)")]
        public string ShipCountry { get; set; }
    }
}