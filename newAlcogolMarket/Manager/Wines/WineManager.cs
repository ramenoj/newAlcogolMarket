using newAlcogolMarket.Models;
using newAlcogolMarket.Models.Entities;

namespace newAlcogolMarket.Manager.Wines
{
    public class WineManager : IWineManager
    {
        private readonly ApplicationContext _context;

        public WineManager(ApplicationContext context)
        {
            _context = context;
        }

        public async Task Add(Wine wine)
        {
           _context.Wines.Add(wine);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var wine = _context.Wines.FirstOrDefault(w => w.Id == id);
            _context.Wines.Remove(wine);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Wine>> Filter(string name)
        {
            var wines = await GetAll();
            if (!string.IsNullOrEmpty(name))
            {
                wines = wines.Where(u => u.Name == name).ToList();
            }
            return wines;
        }

        public  async Task<List<Wine>> GetAll()
        {
            return await _context.Wines.AsNoTracking().ToListAsync();
        }

        public async Task Update(Wine wine)
        {
            _context.Wines.Update(wine);
            await _context.SaveChangesAsync();
        }
    }
}
