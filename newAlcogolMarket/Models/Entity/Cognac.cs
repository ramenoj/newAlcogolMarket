namespace newAlcogolMarket.Models.Entity
{
    public class Cognac
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public ushort Price { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public int FortressId { get; set; }
        public Strength Fortress { get; set; }
        public int SizeId { get; set; }
        public Size Size { get; set; }

    }
}
