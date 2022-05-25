using newAlcogolMarket.Models.Entities;

namespace newAlcogolMarket.Manager.Beers
{
    public interface IBeerManager
    {
        Task<List<Beer>> GetAll();
        Task Add(Beer beer);
        Task Delete(int id);
        Task Update(Beer beer);
        Task<List<Beer>> Filter(string name);
    }
}
