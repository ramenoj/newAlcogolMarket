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

        public async Task Add(ShopItems basket)
        {
            _context.Basket.Add(basket);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var basket = await _context.Basket.FirstOrDefaultAsync(x => x.Id == id);
            _context.Basket.Remove(basket);
            await _context.SaveChangesAsync();
        }

        public async Task<List<ShopItems>> Filter(string name)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ShopItems>> GetAll()
        {
            return await _context.Basket.ToListAsync();
        }

        public async Task Update(ShopItems basket)
        {
            _context.Basket.Update(basket);
            await _context.SaveChangesAsync();
        }
    }
}