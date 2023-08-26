using ClothesWeb.Data.CategoriesModel;
using ClothesWeb.Data.Entites.types.enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClothesWeb.Data.Entites.types
{
    public class Sweater : Clothing
    {

        public sweater_types Name { get; set; }
    }
}
