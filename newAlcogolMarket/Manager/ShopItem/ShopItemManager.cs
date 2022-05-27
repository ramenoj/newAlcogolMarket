using newAlcogolMarket.Models;
using newAlcogolMarket.Models.Entities;

namespace newAlcogolMarket.Manager.ShopItems
{
    public class ShopItemManager : IShopItemManager
    {
        private readonly ApplicationContext _context;

        public ShopItemManager(ApplicationContext context)
        {
            _context = context;
        }

        public async Task Add(ShopItem shopitem)
        {
            _context.ShopItems.Add(shopitem);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var basket = await _context.ShopItems.FirstOrDefaultAsync(x => x.Id == id);
            _context.ShopItems.Remove(basket);
            await _context.SaveChangesAsync();
        }

        public async Task<List<ShopItem>> Filter(string name)
        {
            var shopItems = await GetAll();
            if (!string.IsNullOrEmpty(name))
            {
                //shopItems = shopItems.Where(u => u.Name == name).ToList();
            }
            return shopItems;
        }

        public async Task<List<ShopItem>> GetAll()
        {
            return await _context.ShopItems.ToListAsync();
        }

        public async Task Update(ShopItem basket)
        {
            _context.ShopItems.Update(basket);
            await _context.SaveChangesAsync();
        }
    }
}