using newAlcogolMarket.Models;
using newAlcogolMarket.Models.Entity;

namespace newAlcogolMarket.Manager
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
           _context.Add(absent);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var absent = await _context.Absents.FirstOrDefaultAsync(x => x.Id == id);
            _context.Absents.Remove(absent);
            await _context.SaveChangesAsync();
        }

        public Task<List<Absent>> Filter(string login)
        {
            throw new NotImplementedException();
        }

        public Task<List<Absent>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}