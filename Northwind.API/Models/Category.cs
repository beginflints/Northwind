using System.ComponentModel.DataAnnotations.Schema;

namespace DatingApp.API.Models
{
    [Table("Catagories")]
    public class Category
    {
        public int MyProperty { get; set; }
    }
}