using newAlcogolMarket.Models.Entities;

namespace newAlcogolMarket.Manager.Users
{
    public interface IUserManager
    {
        Task<List<User>> GetAll();
        
        Task Add(User user);
        Task Delete(int id);
        Task Update(User user);
        Task<List<User>> Filter(string login);
      
    }
}