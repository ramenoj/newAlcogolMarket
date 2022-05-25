using newAlcogolMarket.Models;
using newAlcogolMarket.Models.Entities;

namespace newAlcogolMarket.Manager.Vodkas
{
    public class VodkaManager : IVodkaManager
    {
        private readonly ApplicationContext _context;

        public VodkaManager(ApplicationContext context)
        {
            _context = context;
        }

        public async Task Add(Vodka vodka)
        {
            _context.Vodkas.Add(vodka);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var vodka = await _context.Vodkas.FirstOrDefaultAsync(x => x.Id == id);
            _context.Vodkas.Remove(vodka);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Vodka>> Filter(string name)
        {
            var vodkas = await GetAll();
            if (!string.IsNullOrEmpty(name))
            {
                vodkas = vodkas.Where(u => u.Name == name).ToList();
            }
            return vodkas;
        }

        public async Task<List<Vodka>> GetAll()
        {
            return await _context.Vodkas.AsNoTracking().ToListAsync();
        }

        public async Task Update(Vodka vodka)
        {
            _context.Vodkas.Update(vodka);
            await _context.SaveChangesAsync();
        }
    }
}
