using newAlcogolMarket.Models.Entities;

namespace newAlcogolMarket.Manager.Users
{
    public interface IUserManager
    {
        Task<List<User>> GetAll();
        User Get(User user);
        User GetById(int id);
        Task Add(User user);
        Task Delete(int id);
        Task Update(User user);
        Task<List<User>> Filter(string login);
    }
}