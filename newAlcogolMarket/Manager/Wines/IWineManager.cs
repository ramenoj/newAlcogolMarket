using newAlcogolMarket.Models.Entities;

namespace newAlcogolMarket.Manager.Wines
{
    public interface IWineManager
    {
        Task<List<Wine>> GetAll();
        Task Add(Wine wine);
        Task Delete(int id);
        Task Update(Wine wine);
        Task<List<Wine>> Filter(string name);
    }
}
