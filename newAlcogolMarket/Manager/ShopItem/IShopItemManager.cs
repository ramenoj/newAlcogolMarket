using newAlcogolMarket.Models.Entities;
namespace newAlcogolMarket.Manager.ShopItems
{
    public interface IShopItemManager
    {
        Task<List<ShopItem>> GetAll();
        Task Add(ShopItem basket);
        Task Delete(int id);
        Task Update(ShopItem basket);
        Task<List<ShopItem>> Filter(string name);
    }
}
