using newAlcogolMarket.Models.Entities;

namespace newAlcogolMarket.Manager.Champagnes
{
    public interface IChampagneManager
    {
        Task<List<Champagne>> GetAll();
        Task Add(Champagne champagne);
        Task Delete(int id);
        Task Update(Champagne champagne);
        Task<List<Champagne>> Filter(string name);
    }
}
