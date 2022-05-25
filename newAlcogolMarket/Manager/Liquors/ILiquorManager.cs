using newAlcogolMarket.Models.Entities;

namespace newAlcogolMarket.Manager.Liquors
{
    public interface ILiquorManager
    {
        Task<List<Liquor>> GetAll();
        Task Add(Liquor liquor);
        Task Delete(int id);
        Task Update(Liquor liquor);
        Task<List<Liquor>> Filter(string name);
    }
}
