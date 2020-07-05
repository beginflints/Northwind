using System.ComponentModel.DataAnnotations.Schema;

namespace Northwind.API.Models
{
    [Table("Territories")]
    public class Territory
    {
        public string TerritoryId { get; set; }
        public string TerritoryDescription { get; set; }
        public Region Region { get; set; }
    }
}