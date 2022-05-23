using newAlcogolMarket.Models.Entity;
namespace newAlcogolMarket.Manager.Baskets
{
    public interface IBasketManager
    {
        Task<List<Basket>> GetAll();
        Task Add(Basket user);
        Task Delete(int id);
        Task Update(Basket user);
        Task<List<Basket>> Filter(string name);
    }
}
