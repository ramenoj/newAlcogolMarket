using newAlcogolMarket.Models;

namespace newAlcogolMarket.Views
{
    public interface IAlcogolCategories
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
