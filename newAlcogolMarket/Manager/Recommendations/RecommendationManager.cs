using newAlcogolMarket.Models;
using newAlcogolMarket.Models.Entities;

namespace newAlcogolMarket.Manager.Recommendations
{
    public class RecommendationManager : IRecommendationManager
    {
        private readonly ApplicationContext _context;

        public RecommendationManager(ApplicationContext context)
        {
            _context = context;
        }

        public async Task Add(Recommendation recommendation)
        {
           _context.Recommendations.Add(recommendation);
            await _context.SaveChangesAsync();
        }
        public async Task Delete(int id)
        {
            var recommendation = _context.Recommendations.FirstOrDefault(x => x.Id == id);
            _context.Recommendations.Remove(recommendation);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Recommendation>> GetAll()
        {
            return await _context.Recommendations.AsNoTracking().ToListAsync();
        }

        public async Task Update(Recommendation recommendation)
        {
            _context.Recommendations.Update(recommendation);
            await _context.SaveChangesAsync();
        }
    }
}