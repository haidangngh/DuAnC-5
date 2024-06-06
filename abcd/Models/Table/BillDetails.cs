using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment_PH35423.Models.Table
{
    public class BillDetails
    {
        public Guid Id { get; set; }
        public Guid IdProduct { get; set; }
        public Guid IdBill { get; set; }
        public decimal ProductPrice { get; set; }
        public int Quantity { get; set; }
        public int Status { get; set; }
        [ForeignKey("IdProduct")]
        public virtual Products? Product { get; set; }
        [ForeignKey("IdBill")]
        public virtual Bill? Bill { get; set; }
    }
}
