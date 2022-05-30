using newAlcogolMarket.Models;
using newAlcogolMarket.Models.Entities;

namespace newAlcogolMarket.Manager.Baskets
{
    public class BasketManager : IBasketManager
    {
        private readonly ApplicationContext _context;

        public BasketManager(ApplicationContext context)
        {
            _context = context;
        }

        public async Task Add(BasketItem basket)
        {
            _context.BasketItem.Add(basket);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var basket = await _context.BasketItem.FirstOrDefaultAsync(x => x.Id == id);
            _context.BasketItem.Remove(basket);
            await _context.SaveChangesAsync();
        }

        public async Task<List<BasketItem>> Filter(string name)
        {
            throw new NotImplementedException();
        }

        public async Task<List<BasketItem>> GetAll()
        {
            return await _context.BasketItem.ToListAsync();
        }

        public async Task Update(BasketItem basket)
        {
            _context.BasketItem.Update(basket);
            await _context.SaveChangesAsync();
        }
    }
}