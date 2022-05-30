using newAlcogolMarket.Models.Entities;

namespace newAlcogolMarket.Manager.BasketItems
{
    public interface IBasketItemManager
    {
        Task<IList<BasketItem>> GetAll();
        Task Create(BasketItem item);
        Task Delete(int Id);
        Task TotalMount(BasketItem item);
        int Quantity(int count);
    }
}
