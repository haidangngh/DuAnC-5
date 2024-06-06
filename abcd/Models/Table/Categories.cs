using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Assignment_PH35423.Models.Table
{
    public class Categories
    {
        [Key]
        public Guid IdCategory { get; set; }
        [Required]
        public string Name { get; set; } = "";



        public ICollection<Products>? Products { get; set; }
    }
}
