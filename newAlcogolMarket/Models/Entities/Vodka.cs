namespace newAlcogolMarket.Models.Entities
{
    public class Vodka
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public ushort Price { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public int StrengthId { get; set; }
        public Strength Strength { get; set; }
        public int SizeId { get; set; }
        public Size Size { get; set; }

    }
}
