using newAlcogolMarket.Models.Entities;

namespace newAlcogolMarket.Manager.Sizes
{
    public interface ISizeManager
    {
        Task<List<Size>> GetAll();
        Task Add(Size size);
        Task Delete(int id);
        Task Update(Size size);
        Task<List<Size>> Filter(string name);
        Size Get(Size size);
    }
}
