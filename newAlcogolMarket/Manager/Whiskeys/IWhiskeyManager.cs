using newAlcogolMarket.Models.Entities;

namespace newAlcogolMarket.Manager.Whiskeys
{
    public interface IWhiskeyManager
    {
        Task<List<Whiskey>> GetAll();
        Task Add(Whiskey whiskey);
        Task Delete(int id);
        Task Update(Whiskey whiskey);
        Task<List<Whiskey>> Filter(string name);
    }
}
