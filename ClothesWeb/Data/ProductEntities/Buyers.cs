using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClothesWeb.Data.ProductEntities
{
    public class Buyers
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public int PaymentID { get; set; }
        public string Country { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }
        public decimal SellingPrice { get; set; }
        public DateTime updatedate { get; set; }


    }
}
