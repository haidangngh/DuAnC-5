using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Assignment_PH35423.Models.Table
{
    public class Carts
    {
        [Key]
        public Guid IdCart { get; set; }

        [Required]
        public Guid IdCustomers { get; set; }

        [ForeignKey("IdCustomers")]
        public Customers? Customer { get; set; }
        public ICollection<Cart_Detail>? Cart_Detail { get; set; }
    }
}
