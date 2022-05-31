using newAlcogolMarket.Models;
using newAlcogolMarket.Models.Entities;

namespace newAlcogolMarket.Manager.Snacks
{
    public class SnackManager : ISnackManager
    {
        private readonly ApplicationContext _context;

        public SnackManager(ApplicationContext context)
        {
            _context = context;
        }

        public async Task Add(Snack snack)
        {
            _context.Snacks.Add(snack);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var snack = _context.Snacks.FirstOrDefault(x => x.Id == id);
            _context.Snacks.Remove(snack);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Snack>> Filter(string name)
        {
            var snacks = await GetAll();
            if (!string.IsNullOrEmpty(name))
            {
                snacks = snacks.Where(u => u.Name == name).ToList();
            }
            return snacks;
        }
        public Snack Get(int id)
        {
            return _context.Snacks.FirstOrDefault(s => s.Id == id);
        }

        public async Task<List<Snack>> GetAll()
        {
            //return await _context.Snacks.Include(x => x.Weight).ToListAsync();
            return await _context.Snacks.ToListAsync();
        }

        public async Task Update(Snack snack)
        {
            _context.Snacks.Update(snack);
            await _context.SaveChangesAsync();
        }
    }
}