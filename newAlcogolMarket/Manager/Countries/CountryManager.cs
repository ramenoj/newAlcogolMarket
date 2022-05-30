using newAlcogolMarket.Models;
using newAlcogolMarket.Models.Entities;

namespace newAlcogolMarket.Manager.Countries
{
    public class CountryManager:ICountryManager
    {
        private readonly ApplicationContext _context;

        public CountryManager(ApplicationContext context)
        {
            _context = context;
        }

        public async Task Add(Country country)
        {
            _context.Countries.Add(country);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var country = _context.Countries.FirstOrDefault(x => x.Id == id);
            _context.Countries.Remove(country);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Country>> Filter(string name)
        {
            var countries = await GetAll();
            if (!string.IsNullOrEmpty(name))
            {
                countries = countries.Where(u => u.Name == name).ToList();
            }
            return countries;
        }

        public Country Get(Country country)
        {
            return _context.Countries.FirstOrDefault(x => x.Id == country.Id);
        }

        public async Task<List<Country>> GetAll()
        {
            return await _context.Countries.AsNoTracking().ToListAsync();
        }

        public async Task Update(Country country)
        {
            _context.Countries.Update(country);
            await _context.SaveChangesAsync();
        }
    }
}
