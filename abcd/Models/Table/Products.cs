using abcd.Models;
using PH33706database.Models.Table;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Assignment_PH35423.Models.Table
{
    public class Products
    {
        
        [Key]
        public Guid IdProduct { get; set; }
        [Required]
        [MaxLength(15)]
        [RegularExpression(@"^\d{15}$", ErrorMessage = "Không đúng định dạng IMEI")]
        
        public string IMEI { get; set; } = "";
        [Required]
        public string Name { get; set; } = "";
        public Guid IdBrand { get; set; }
        public Guid CameraID { get; set; }
        public Guid DisplayID { get; set; }
        [Required]
        public string Description { get; set; } = "";
        [Required]
        public string? Img { get; set; } = StaticService.RandomImg();
        [Required]
        public double  Price { get; set; }
        [Required]
        public int? Quantity { get; set; }

        public Guid IdCategory { get; set; }

        public bool IsDeleted { get; set; } = false;
  


        [ForeignKey ("IdCategory")]
        public Categories? Category{ get; set; } 
        public virtual ProductsBrand? productsbrands { get; set; }
        public virtual ProductsCamera? ProductsCameras { get; set; }
        public virtual ProductsDisplay? ProductsDisplays { get; set; }
    }
}
