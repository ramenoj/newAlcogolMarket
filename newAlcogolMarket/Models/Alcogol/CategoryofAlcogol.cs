using System.ComponentModel.DataAnnotations;

namespace newAlcogolMarket.Models.Alcogol
{
    public class CategoryofAlcogol
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
