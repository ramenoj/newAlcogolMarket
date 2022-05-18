using System.ComponentModel.DataAnnotations;

namespace newAlcogolMarket.Models.Entity
{
    public class CategoryofAlcogol
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
