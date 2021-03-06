using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Northwind.API.Models
{
    [Table("Catagories")]
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        [Column(TypeName="image")]
        public byte[] Picture { get; set; }
    }
}