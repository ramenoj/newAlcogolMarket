namespace newAlcogolMarket.Models.Entities
{
    public class Snack
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public ushort Price { get; set; }
        public ushort Weight { get; set; }
    }
}
