using ClothesWeb.Data.CategoriesModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClothesWeb.Data.Entites.types
{
    public class Clothing
    {
        [Key]
        public int? Id { get; set; }
        public Colors Colors { get; set; }
        public Size? Size { get; set; }
        public Materials Material { get; set; }
        [ForeignKey("Deigners")]
        public int DesignerID { get; set; }
        public virtual Designers Designers { get; set; } = new Designers();
        public DateTime registration_date { get; set; }
        public Image? MainImage => Images.FirstOrDefault();
        public virtual ICollection<Image> Images { get; set; } = new List<Image>();
        public virtual Category Category { get; set; }
    }
}
