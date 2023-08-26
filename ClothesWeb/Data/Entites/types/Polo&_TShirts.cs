using ClothesWeb.Data.CategoriesModel;
using ClothesWeb.Data.Entites.types.enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClothesWeb.Data.Entites.types
{
    public class Polo_TShirts : Clothing
    {
        public Polo_Tshirt_Type Name { get; set; }
      
    }
}
