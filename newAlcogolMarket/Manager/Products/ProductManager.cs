using newAlcogolMarket.Models;
using newAlcogolMarket.Models.Entities;

namespace newAlcogolMarket.Manager.Products
{
    public class ProductManager:IProductManager
    {
        private readonly ApplicationContext _context;

        public ProductManager(ApplicationContext context)
        {
            _context = context;
        }

        public async Task Add(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var product = _context.Products.FirstOrDefault(x => x.Id == id);
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Product>> Filter(string name)
        {
            var products = await GetAll();
            if (!string.IsNullOrEmpty(name))
            {
                products = products.Where(u => u.Name == name).ToList();
            }
            return products;
        }

        public Product Get(Product product)
        {
            return _context.Products.Include(x=>x.Category).Include(x=>x.Country).Include(x=>x.Size).FirstOrDefault(u => u.Id == product.Id);
        }

        public async Task<List<Product>> GetAll()
        {
            return await _context.Products.Include(x => x.Category).Include(x => x.Size).Include(x => x.Country).ToListAsync();
        }

        public async Task<List<Product>> GetAllByCategory(string categoryName)
        {
            return await _context.Products.Include(x=>x.Category).Include(x => x.Size).Include(x => x.Country).Where(x => x.Category.Name == categoryName).ToListAsync();
        }

        public async Task Update(Product product)
        {
            _context.Products.Update(product);
            await _context.SaveChangesAsync();
        }
    }
}
