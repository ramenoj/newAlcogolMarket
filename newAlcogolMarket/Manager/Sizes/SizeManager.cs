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

        public async Task<List<Size>> Filter(string name)
        {
            
        }

        public Task<List<Size>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task Update(Size basket)
        {
            throw new NotImplementedException();
        }
    }
}
