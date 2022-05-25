using newAlcogolMarket.Models;
using newAlcogolMarket.Models.Entities;

namespace newAlcogolMarket.Manager.Users
{
    public class UserManager:IUserManager
    {
        ApplicationContext _context;

        public UserManager(ApplicationContext context)
        {
            _context = context;
        }

        public async Task Add(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Id == id);

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
        }

        public async Task<List<User>> Filter(string? login)
        {
            var users = await GetAll();

            if (!string.IsNullOrEmpty(login))
            {
                users = users.Where(u => u.Login == login).ToList();
            }
            return users;
        }

        public async Task<List<User>> GetAll()
        {
            return await _context.Users.AsNoTracking().ToListAsync();
        }
        public async Task Update(User user)
        {
            _context.Users.Update(user);
            await _context.SaveChangesAsync();
        }
    }
}
