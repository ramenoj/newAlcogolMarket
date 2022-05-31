using newAlcogolMarket.Models;
using newAlcogolMarket.Models.Entities;

namespace newAlcogolMarket.Manager.Sizes
{
    public class SizeManager:ISizeManager
    {
        private readonly ApplicationContext _context;

        public SizeManager(ApplicationContext context)
        {
            _context = context;
        }

        public async Task Add(Size size)
        {
             _context.Sizes.Add(size);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var size = await _context.Sizes.FirstOrDefaultAsync(x => x.Id == id);
            _context.Sizes.Remove(size);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Size>> Filter(Size size)
        {
            var shopItems = await GetAll();
            shopItems = shopItems.Where(u => u.Volume == size.Volume).ToList();
           
            return shopItems;
        }

        public  Size Get(Size size)
        {
           return _context.Sizes.FirstOrDefault(x => x.Id == size.Id);
        }

        public async Task<List<Size>> GetAll()
        {
            return await _context.Sizes.AsNoTracking().ToListAsync();
        }

        public async Task Update(Size size)
        {
            _context.Sizes.Update(size);
            await _context.SaveChangesAsync();
        }
    }
}
