using System.ComponentModel.DataAnnotations.Schema;

namespace DatingApp.API.Models
{
    [Table("Catagories")]
    public class Category
    {
        public int CategoryID { get; set; }
        [Column(TypeName="nvarchar(15)")]
        public string CategoryName { get; set; }
        public string Description { get; set; }
        [Column(TypeName="image")]
        public byte[] MyProperty { get; set; }
    }
}