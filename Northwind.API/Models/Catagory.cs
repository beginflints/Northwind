using System.ComponentModel.DataAnnotations.Schema;

namespace DatingApp.API.Models
{
    [Table("Catagories")]
    public class Catagory
    {
        public int MyProperty { get; set; }
    }
}