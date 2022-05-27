using newAlcogolMarket.Models;
using newAlcogolMarket.Models.Entities;

namespace newAlcogolMarket.Manager.Categories
{
    public class CategoryManager:ICategoryManager
    {
        private readonly ApplicationContext _context;

        public CategoryManager(ApplicationContext context)
        {
            _context = context;
        }

        public async Task Add(Category category)
        {
            _context.Categories.Add(category);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var category = _context.Products.FirstOrDefault(x => x.Id == id);
            _context.Products.Remove(category);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Category>> Filter(string name)
        {
            var categories = await GetAll();
            if (!string.IsNullOrEmpty(name))
            {
                categories = categories.Where(u => u.Name == name).ToList();
            }
            return categories;
        }

        public async Task<List<Category>> GetAll()
        {
            return await _context.Categories.AsNoTracking().ToListAsync();
        }

        public async Task Update(Category category)
        {
            _context.Categories.Update(category);
            await _context.SaveChangesAsync();
        }
    }
}
