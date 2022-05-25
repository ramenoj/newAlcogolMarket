using newAlcogolMarket.Models;
using newAlcogolMarket.Models.Entities;

namespace newAlcogolMarket.Manager.Champagnes
{
    public class ChampagneManager : IChampagneManager
    {
        private readonly ApplicationContext _context;

        public ChampagneManager(ApplicationContext context)
        {
            _context = context;
        }

        public async Task Add(Champagne champagne)
        {
            _context.Champagnes.Add(champagne);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var champagne = _context.Champagnes.FirstOrDefault(x => x.Id == id);
            _context.Champagnes.Remove(champagne);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Champagne>> Filter(string name)
        {
            var champagnes = await GetAll();

            if (!string.IsNullOrEmpty(name))
            {
                champagnes = champagnes.Where(u => u.Name == name).ToList();
            }
            return champagnes;
        }

        public async Task<List<Champagne>> GetAll()
        {
            return await _context.Champagnes.AsNoTracking().ToListAsync();
        }

        public async Task Update(Champagne champagne)
        {
            _context.Champagnes.Update(champagne);
            await _context.SaveChangesAsync();
        }
    }
}
