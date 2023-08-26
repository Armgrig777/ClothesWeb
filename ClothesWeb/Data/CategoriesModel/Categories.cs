using ClothesWeb.Data.Entites.types;
using ClothesWeb.Data.Entites.types.enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClothesWeb.Data.CategoriesModel
{
    public class CategoriesModel
    {

        public int Id { get; set; }
        public string TypeName { get; set; }
        public DateTime DateTime { get; set; }
        public string Colors { get; set; }
        public string Size { get; set; } = "";
        public int? ShoeSize { get; set; }
        public string Material { get; set; }
        public string Designer { get; set; }
        public byte[]? MainImage => Images.FirstOrDefault();
        public LinkedList<byte[]> Images { get; set; } = new LinkedList<byte[]>();

    }
   
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public ClothingCategory ClothingCategory { get; set; }
    }
}
