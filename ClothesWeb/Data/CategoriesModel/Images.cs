using ClothesWeb.Data.Entites.types;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClothesWeb.Data.CategoriesModel
{
    public class Image
    {
        [Key]
        public int Id { get; set; }
        public byte[] ImageUrl { get; set; } = new byte[0];
       
        [ForeignKey("Clothing")]
        public int? ClothesId { get; set; }
        public virtual Clothing Clothes { get; set; } = new Clothing();
    }
}
