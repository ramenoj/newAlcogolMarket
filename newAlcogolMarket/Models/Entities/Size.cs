namespace newAlcogolMarket.Models.Entities
{
    public class Size
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public double Volume { get; set; }
    }
}
