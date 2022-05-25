using newAlcogolMarket.Models;
using newAlcogolMarket.Models.Entities;

namespace newAlcogolMarket.Manager.Countries
{
    public class CountryManager : ICountryManager
    {
        private readonly ApplicationContext _context;

        public CountryManager(ApplicationContext context)
        {
            _context = context;
        }

        public Task Add(Country country)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Country>> Filter(string name)
        {
            throw new NotImplementedException();
        }

        public Task<List<Country>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task Update(Country country)
        {
            throw new NotImplementedException();
        }
    }
}
