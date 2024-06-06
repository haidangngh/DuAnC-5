using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Assignment_PH35423.Models.Table
{
    public class Cart_Detail
    {
        [Key]
        public Guid IdCart_Detail { get; set; }
        [Required]
        public Guid IdCart { get; set; }

        [Required]
        public Guid IdProduct { get; set; }

        [ForeignKey("IdProduct")]
        public Products? Products { get; set; }

        [Required]
        public int Quantity { get; set; }

        public bool IsDeleted { get; set; } = false;


        [ForeignKey("IdCart")]
        public  Carts? Cart { get; set; }
    }
}
