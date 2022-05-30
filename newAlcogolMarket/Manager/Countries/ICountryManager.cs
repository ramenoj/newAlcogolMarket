using newAlcogolMarket.Models.Entities;

namespace newAlcogolMarket.Manager.Countries
{
    public interface ICountryManager
    {
        Task<List<Country>> GetAll();
        Task Add(Country country);
        Task Delete(int id);
        Task Update(Country country);
        Task<List<Country>> Filter(string name);
        Country Get(Country country);
    }
}
