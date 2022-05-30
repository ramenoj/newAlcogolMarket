using newAlcogolMarket.Models.Entities;

namespace newAlcogolMarket.Manager.Snacks
{
    public interface ISnackManager
    {
        Task<List<Snack>> GetAll();
        Task Add(Snack snack);
        Task Delete(int id);
        Task Update(Snack snack);
        Task<List<Snack>> Filter(string name);
        Snack Get(Snack snack);
    }
}
