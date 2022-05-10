using newAlcogolMarket.Models;

namespace newAlcogolMarket.Views
{
    public interface IAllAlcogols
    {
        IEnumerable<Alcogol> Alcogols { get; set; }
        IEnumerable<Alcogol> getFavAlcogol { get; set; }
        Alcogol GetAlcogolById(int id);
    }
}
