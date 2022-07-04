using newAlcogolMarket.Models;
using newAlcogolMarket.Models.Entities;

namespace newAlcogolMarket.Manager.BasketItems
{
    public class BasketItemManager:IBasketItemManager
    {
        private readonly ApplicationContext _context;
        public BasketItemManager(ApplicationContext context)
        {
            _context = context;
        }
        public async Task<IList<BasketItem>> GetAll()
        {
            return await _context.BasketItem.ToListAsync();
        }
        public async Task Create(BasketItem item)
        {
            _context.BasketItem.Add(item);
            await _context.SaveChangesAsync();
        }
        public async Task Delete(int Id)
        {
            var Item = _context.BasketItem.FirstOrDefault(x => x.Id == Id);
            if (Item != null)
            {
                _context.BasketItem.Remove(Item);
                await _context.SaveChangesAsync();
            }
        }

        public Task TotalMount(BasketItem item)
        {
            throw new NotImplementedException();
        }
        public async Task Clear()
        {
            foreach(var item in _context.BasketItem)
            {
                _context.BasketItem.Remove(item);
            }
            await _context.SaveChangesAsync();
        }
    }
}
