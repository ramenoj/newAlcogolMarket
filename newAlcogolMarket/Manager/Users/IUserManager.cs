using newAlcogolMarket.Models.Entities;

namespace newAlcogolMarket.Manager.Users
{
    public interface IUserManager
    {
        Task<List<User>> GetAll();
        User Get(User user);
        Task Add(User user);
        Task Delete(int id);
        Task Update(User user);
        Task<List<User>> Filter(string login);
    }
}