using newAlcogolMarket.Models;
using newAlcogolMarket.Models.Entity;

namespace newAlcogolMarket.Manager
{
    public class AbsentManager:IAbsentManager
    {
        private readonly ApplicationContext _context;
        public AbsentManager (ApplicationContext context)
        {
            _context = context;
        }
        public async Task<IList<CategoryofAlcogol>> GetAll() => await _context.CategoryofAlcogol.ToListAsync();
        public async Task Create(string name)
        {
            var category = new CategoryofAlcogol { Name = name };
            _context.CategoryofAlcogol.Add(category);
            await _context.SaveChangesAsync();
        }
        public  async Task Delete(int Id)
        {
           var category= _context.CategoryofAlcogol.FirstOrDefault(c => c.Id == Id);
            if(category != null)
            {
                _context.CategoryofAlcogol.Remove(category);
                await _context.SaveChangesAsync();
            }
        }
    }
}