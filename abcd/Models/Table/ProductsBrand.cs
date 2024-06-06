using Assignment_PH35423.Models.Table;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PH33706database.Models.Table
{
    public class ProductsBrand
    {
        
        [Key]
        [ForeignKey("IdBrand")]
        public Guid IdBrand { get; set; }
        [Required]
        public string? BrandName { get; set; }
        [Required]
        public string? BrandDescription { get; set; }
        [Required]
        public string? BrandProductsQuanlity { get; set; } //so luong san pham cua brand
        public ICollection<Products>? Products { get; set; }


    }
}
