﻿namespace newAlcogolMarket.Models.Category
{
    public class Liquor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ushort price { get; set; }
        public int degree { get; set; }
        public string country { get; set; }
    }
}
