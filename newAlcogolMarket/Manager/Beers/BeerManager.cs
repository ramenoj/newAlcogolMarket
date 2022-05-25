using newAlcogolMarket.Models;
using newAlcogolMarket.Models.Entities;

namespace newAlcogolMarket.Manager.Beers
{
    public class BeerManager : IBeerManager
    {
        private readonly ApplicationContext _context;

        public BeerManager(ApplicationContext context)
        {
            _context = context;
        }

        public async Task Add(Beer beer)
        {
            _context.Beers.Add(beer);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var beer = await _context.Beers.FirstOrDefaultAsync(x => x.Id == id);
            _context.Beers.Remove(beer);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Beer>> Filter(string name)
        {
            var beers = await GetAll();
            if (!string.IsNullOrEmpty(name))
            {
                beers = beers.Where(u => u.Name == name).ToList();
            }
            return beers;
        }

        public async Task<List<Beer>> GetAll()
        {
            return await _context.Beers.AsNoTracking().ToListAsync();
        }
        public async Task Update(Beer beer)
        {
            _context.Beers.Update(beer);
            await _context.SaveChangesAsync();
        }
    }
}
