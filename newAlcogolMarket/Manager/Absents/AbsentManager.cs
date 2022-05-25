using newAlcogolMarket.Models;
using newAlcogolMarket.Models.Entities;

namespace newAlcogolMarket.Manager.Absents
{
    public class AbsentManager : IAbsentManager
    {
        ApplicationContext _context;

        public AbsentManager(ApplicationContext context)
        {
            _context = context;
        }

        public async Task Add(Absent absent)
        {
            _context.Absents.Add(absent);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var absent = await _context.Absents.FirstOrDefaultAsync(x => x.Id == id);
            _context.Absents.Remove(absent);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Absent>> Filter(string? name)
        {
            var absents = await GetAll();

            if (!string.IsNullOrEmpty(name))
            {
                absents = absents.Where(u => u.Name == name).ToList();
            }
            return absents;
        }

        public async Task<List<Absent>> GetAll()
        {
            return await _context.Absents.AsNoTracking().ToListAsync();
        }
        public async Task Update(Absent absent)
        {
            _context.Absents.Update(absent);
            await _context.SaveChangesAsync();
        }
    }
}