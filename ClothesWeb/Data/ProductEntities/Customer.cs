using ClothesWeb.Data.Entites.types.enums;
using System.ComponentModel.DataAnnotations;

namespace ClothesWeb.Data.ProductEntities
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public string PhoneNumber { get; set; } = string.Empty;
        [Required]
        public string Address { get; set; }
        [Required]
        public string Country { get; set; }
        public DateTime DateTime { get; set; }
        public bool RegisterStatus { get; set; } = false;
        public Selling_Status status { get; set; }


    }
}
