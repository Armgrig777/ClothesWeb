using ClothesWeb.Data.CategoriesModel;
using ClothesWeb.Data.Entites.types.enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClothesWeb.Data.Entites.types
{
    public class Coats_jackets : Clothing
    {
        public Coats_jackets_types Name { get; set; }  
    }
}
