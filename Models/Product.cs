
using System.ComponentModel.DataAnnotations;

namespace SimpleWebApp.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string? ProductName { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        public string Description { get; set; }

        public DateTime CreateDate { get; set; }

    }
}
