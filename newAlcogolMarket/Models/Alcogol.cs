namespace newAlcogolMarket.Models
{
    public class Alcogol
    {
        public int id { get; set; }
        public string name { get; set; }
        public ushort price { get; set; }
        public short Desc { get; set; }
        public string img { get; set; }
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}
