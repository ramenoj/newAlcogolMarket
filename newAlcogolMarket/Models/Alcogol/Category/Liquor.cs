using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace newAlcogolMarket.Models.Alcogol.Category
{
    public class Liquor
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ushort price { get; set; }
        public int degree { get; set; }
        public string country { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [ForeignKey(nameof(CategoryId))]
        public virtual CategoryofAlcogol Category { get; set; }
    }
}
