using newAlcogolMarket.Models;
using newAlcogolMarket.Models.Entities;

namespace newAlcogolMarket.Manager.Liquors
{
    public class LiquorManager:ILiquorManager
    {
        private readonly ApplicationContext _context;

        public LiquorManager(ApplicationContext context)
        {
            _context = context;
        }

        public async Task Add(Liquor liquor)
        {
            _context.Liquors.Add(liquor);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var liquor=_context.Liquors.FirstOrDefault(l => l.Id == id);
            _context.Liquors.Remove(liquor);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Liquor>> Filter(string name)
        {
            var liquors = await GetAll();
            if (!string.IsNullOrEmpty(name))
            {
                liquors = liquors.Where(u => u.Name == name).ToList();
            }
            return liquors;
        }

        public async Task<List<Liquor>> GetAll()
        {
            return await _context.Liquors.AsNoTracking().ToListAsync();
        }

        public async Task Update(Liquor liquor)
        {
            _context.Liquors.Update(liquor);
            await _context.SaveChangesAsync();
        }
    }
}
