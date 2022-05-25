using newAlcogolMarket.Models.Entities;

namespace newAlcogolMarket.Manager.Vodkas
{
    public interface IVodkaManager
    {
        Task<List<Vodka>> GetAll();

        Task Add(Vodka vodka);
        Task Delete(int id);
        Task Update(Vodka vodka);
        Task<List<Vodka>> Filter(string name);
    }
}
