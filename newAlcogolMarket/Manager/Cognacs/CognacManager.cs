using newAlcogolMarket.Models;
using newAlcogolMarket.Models.Entities;

namespace newAlcogolMarket.Manager.Cognacs
{
    public class CognacManager:ICognacManager
    {
        private readonly ApplicationContext _context;

        public CognacManager(ApplicationContext context)
        {
            _context = context;
        }

        public async Task Add(Cognac cognac)
        {
            _context.Cognacs.Add(cognac);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var cognac = _context.Cognacs.FirstOrDefault(c => c.Id == id);  
            _context.Cognacs.Remove(cognac);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Cognac>> Filter(string name)
        {
            var cognacs = await GetAll();

            if (!string.IsNullOrEmpty(name))
            {
               cognacs= cognacs.Where(u => u.Name == name).ToList();
            }
            return cognacs;
        }

        public async Task<List<Cognac>> GetAll()
        {
            return await _context.Cognacs.AsNoTracking().ToListAsync();
        }

        public async Task Update(Cognac cognac)
        {
            _context.Cognacs.Update(cognac);
            await _context.SaveChangesAsync();
        }
    }
}
