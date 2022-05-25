using newAlcogolMarket.Models;
using newAlcogolMarket.Models.Entities;

namespace newAlcogolMarket.Manager.Whiskeys
{
    public class WhiskeyManager : IWhiskeyManager
    {
        private readonly ApplicationContext _context;
        public async Task Add(Whiskey whiskey)
        {
            _context.Whiskey.Add(whiskey);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var whiskey = await _context.Whiskey.FirstOrDefaultAsync(x => x.Id == id);
            _context.Whiskey.Remove(whiskey);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Whiskey>> Filter(string name)
        {
            var whiskeys = await GetAll();
            if (!string.IsNullOrEmpty(name))
            {
                whiskeys = whiskeys.Where(u => u.Name == name).ToList();
            }
            return whiskeys;
        }

        public async Task<List<Whiskey>> GetAll()
        {
            return await _context.Whiskey.AsNoTracking().ToListAsync();
        }

        public async Task Update(Whiskey whiskey)
        {
            _context.Whiskey.Update(whiskey);
            await _context.SaveChangesAsync();
        }
    }
}
