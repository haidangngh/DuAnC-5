using Assignment_PH35423.Models.Table;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PH33706database.Models.Table
{
    public class ProductsDisplay
    {
        [Key]
        [ForeignKey("DisplayID")]
        public Guid DisplayID { get; set; }
        [Required]
        public string? DisplayName { get; set; }
        [Required]
        public string? DisplayCategory { get; set; }
        [Required]
        public float DisplaySize { get; set; }
        [Required]
        public float DisplayPrice { get; set; }
        [Required]
        public float DisplayBrightness { get; set; }
        public ICollection<Products>? Products { get; set; }
    }
}
