namespace newAlcogolMarket.Models.Entity
{
    public class Whiskey
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ushort Price { get; set; }
        public int Degree { get; set; }
        public int DegreeId { get; set; }
        public int SizeId { get; set; }
        public double Size { get; set; }
        public int CountryId { get; set; }
        public string Country { get; set; }


    }
}
