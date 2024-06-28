using System.ComponentModel.DataAnnotations;

namespace SLD521_SA.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        [Range(0.01, 10000.00)]
        public decimal Price { get; set; }

        public string? Description { get; set; }

        [Required]
        [Range(0, 1000)]
        public int StockQuantity { get; set; }
    }
}

