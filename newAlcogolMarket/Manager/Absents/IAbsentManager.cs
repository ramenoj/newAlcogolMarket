using newAlcogolMarket.Models.Entity;

namespace newAlcogolMarket.Manager
{

    public interface IAbsentManager
    {

        Task<IList<Absent>> GetAll();
        Task Create(string Name);
        Task Delete(int Id);

    }
}

