using Assignment_PH35423.Models.Table;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PH33706database.Models.Table
{
    public class ProductsCamera
    {
        [Key]
        [ForeignKey("CameraID")]
        public Guid CameraID { get; set; }
        [Required]
        public string? CameraStatus { get; set; } //64MP
        public string? CameraSpecialFeature { get; set; } //ChongRung
        [Required]
        public string? CameraCategory { get; set; } //taitho
        public ICollection<Products>? Products { get; set; }

    }
}
