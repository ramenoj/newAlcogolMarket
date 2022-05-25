using newAlcogolMarket.Models.Entities;
namespace newAlcogolMarket.Manager.Absents
{
    public interface IAbsentManager
    {
        Task<List<Absent>> GetAll();
        Task Add(Absent absent);
        Task Delete(int id);
        Task Update(Absent absent);
        Task<List<Absent>> Filter(string name);
    }
}