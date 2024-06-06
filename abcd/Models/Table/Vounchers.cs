using System.ComponentModel.DataAnnotations;

namespace Assignment_PH35423.Models.Table
{
    public class Vounchers
    {
        public Guid Id { get; set; }
        [Required]
        public string? IdVouncher { get; set; }
        [Required]
        public string? Name { get; set; }

        public string? Description { get; set; }
        [Required]

        public int Quanlity { get; set; }
        [Required]

        public decimal DiscountValue { get; set; }
        [Required]
        public int Status { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public ICollection<Bill>? Bill { get; set; }
    }
}
