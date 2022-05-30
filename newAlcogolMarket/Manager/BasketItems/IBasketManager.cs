using newAlcogolMarket.Models.Entities;
namespace newAlcogolMarket.Manager.Baskets
{
    public interface IBasketManager
    {
        Task<List<BasketItem>> GetAll();
        Task Add(BasketItem basket);
        Task Delete(int id);
        Task Update(BasketItem basket);
        Task<List<BasketItem>> Filter(string name);
    }
}
