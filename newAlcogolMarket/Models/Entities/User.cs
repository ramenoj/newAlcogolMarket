namespace newAlcogolMarket.Models.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public List<BasketItem>? BasketItems { get; set; }
    }
}
