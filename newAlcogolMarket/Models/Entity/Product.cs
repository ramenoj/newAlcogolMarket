namespace newAlcogolMarket.Models.Entity
{
    public class Product
    {
        [Key]
        public int Id { get; set; } 
        public string Name { get; set; }
        public ushort Price { get; set; }
        public int CategoryId { get; set; }
        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; }
        public int CountryId { get; set; }
        [ForeignKey(nameof(CountryId))]
        public Country Country { get; set; }
        public double Strength { get; set; }
        public int SizeId { get; set; }
        public Size Size { get; set; }
    }
}
