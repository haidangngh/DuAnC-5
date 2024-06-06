using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment_PH35423.Models.Table
{
    public class Bill
    {
        [Key]
        public Guid IdBill { get; set; }
        [Required]
        public DateTime CreateDate { get; set; }
        public decimal Money { get; set; }
        public Guid IdCustomer { get; set; }
        public int Status { get; set; }
        // Quan hệ - Navigation
        public virtual List<BillDetails>? BillDetails { get; set; }
        [ForeignKey("IdCustomer")]
        public virtual Customers? Customer { get; set; }
        [ForeignKey("IdVouncher")]
        public Guid IdVouncher { get; set; }

    }
}
