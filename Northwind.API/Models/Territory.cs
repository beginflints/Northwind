using System.ComponentModel.DataAnnotations.Schema;

namespace Northwind.API.Models
{
    [Table("Territories")]
    public class Territory
    {
        public string TerritoryID { get; set; }
        public string TerritoryDescription { get; set; }
        public Region Region { get; set; }
    }
}