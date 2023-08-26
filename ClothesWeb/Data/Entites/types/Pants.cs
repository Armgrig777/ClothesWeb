using ClothesWeb.Data.CategoriesModel;
using ClothesWeb.Data.Entites.types.enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClothesWeb.Data.Entites.types
{
    public class Pants:Clothing
    {
        public pants_types Name { get; set; }
       
    }
}
