using newAlcogolMarket.Models.Entities;

namespace newAlcogolMarket.Manager.Categories
{
    public interface ICategoryManager
    {
        Task<List<Category>> GetAll();
        Task Add(Category category);
        Task Delete(int id);
        Task Update(Category category);
        Task<List<Category>> Filter(string name);
        Category Get(Category category);
    }
}
