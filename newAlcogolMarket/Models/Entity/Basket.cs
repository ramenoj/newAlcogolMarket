namespace newAlcogolMarket.Models.Entity
{
    public class Basket
    {
        [Key]
        public int Id { get; set; }
        public int Name { get; set; }
        public int Price { get; set; }
    }
}
