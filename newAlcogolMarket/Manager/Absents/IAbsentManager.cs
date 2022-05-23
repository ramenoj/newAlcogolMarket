using newAlcogolMarket.Models.Entity;
namespace newAlcogolMarket.Manager
{
    public interface IAbsentManager
    {
        Task<List<Absent>> GetAll();
        Task Add(Absent absent);
        Task Delete(int id);
        Task Update(User user);
        Task<List<User>> Filter(string login);
    }
}