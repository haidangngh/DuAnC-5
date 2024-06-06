using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Assignment_PH35423.Models.Table
{
    public class Customers
    {
        
        [Key]
        public Guid IdCustomers { get; set; }
        [Required]
        [MaxLength(10)]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Số điện thoại không hợp lệ.")]

        public string PhoneNumber { get; set; } = "";
        [Required]
        public string Name { get; set; } = "";
        [Required]
        public string Address { get; set; } = "";
        [Required]
        public bool Sex { get; set; }
        [Required]
        public string? Password { get; set; }

        public AccounType Role { get; set; }

        public bool IsDeleted { get; set; } = false;

        public Carts? Cart { get; set; }

        
    }
}
