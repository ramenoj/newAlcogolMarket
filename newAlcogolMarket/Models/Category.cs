namespace newAlcogolMarket.Models
{
    public class Category
    {
        public int id { get; set; }
        public string Categoryname { get; set; }
        public string desc { get; set; }
        public List<Alcogol> alcogols { get; set; }
    }
}
