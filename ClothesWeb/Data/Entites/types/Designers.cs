using System.ComponentModel.DataAnnotations;

namespace ClothesWeb.Data.Entites.types
{
    public class Designers
    {
        [Key]
        public int Id { get; set; }
        public string designer_name { get; set; }
        public DateTime registration_date { get; set; }
        public string registration_status { get; set; }

    }
}
