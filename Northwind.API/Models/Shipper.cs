using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Northwind.API.Models
{
    [Table("Shippers")]
    public class Shipper
    {
        public int ShipperID { get; set; }
        [NotNull]
        public string CompanyName { get; set; }
        public string Phone { get; set; }
    }
}