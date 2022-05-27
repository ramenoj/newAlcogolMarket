using newAlcogolMarket.Models.Entities;
namespace newAlcogolMarket.Manager.Baskets
{
    public interface IBasketManager
    {
        Task<List<ShopItems>> GetAll();
        Task Add(ShopItems basket);
        Task Delete(int id);
        Task Update(ShopItems basket);
        Task<List<ShopItems>> Filter(string name);
    }
}
