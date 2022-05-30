using newAlcogolMarket.Models.Entities;

namespace newAlcogolMarket.Manager.Recommendations
{
    public interface IRecommendationManager
    {
        Task<List<Recommendation>> GetAll();
        Task Add(Recommendation recommendation);
        Task Delete(int id);
        Task Update(Recommendation recommendation);
    }
}
