using newAlcogolMarket.Models.Entity;

namespace newAlcogolMarket.Manager.Beers
{
    public interface IBeerManager
    {
        Task<List<Beer>> GetAll();
        Beer GetUser(Beer user);
        Task AddUser(Beer user);
        Task DeleteUser(int id);
        Task UpdateUser(Beer user);
        Task<List<Beer>> Filter(string name);
    }
}
