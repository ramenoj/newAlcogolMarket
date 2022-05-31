namespace newAlcogolMarket.Models.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public List<BasketItem>? BasketItems { get; internal set; }
    }
}
