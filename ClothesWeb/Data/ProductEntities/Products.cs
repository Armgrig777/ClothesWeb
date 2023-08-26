using ClothesWeb.Data.CategoriesModel;
using ClothesWeb.Data.Entites;
using ClothesWeb.Data.Entites.types;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClothesWeb.Data.ProductEntities
{
    public class Products
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; } = new Category();
        [ForeignKey("Designer")]    
        public int ProductId { get; set; }
        public virtual Designers Designers { get; set; } = new Designers();

        public Materials Materials { get; set; }
        public Colors Colors { get; set; }
        public Size Sizes { get; set; }
        public int? Shoesize { get; set; }
        public decimal SellingPrice { get; set; }
        public decimal PrimeCost { get; set; }
        public DateTime Registration_Date { get; set; }
        public bool Registration_Status { get; set; } = false;


    }
}
