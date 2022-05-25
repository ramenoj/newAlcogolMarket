using newAlcogolMarket.Models.Entities;

namespace newAlcogolMarket.Manager.Cognacs
{
    public interface ICognacManager
    {
        Task<List<Cognac>> GetAll();
        Task Add(Cognac cognac);
        Task Delete(int id);
        Task Update(Cognac cognac);
        Task<List<Cognac>> Filter(string name);
    }
}
