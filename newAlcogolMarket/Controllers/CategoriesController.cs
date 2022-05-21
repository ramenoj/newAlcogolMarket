using Microsoft.AspNetCore.Mvc;
using newAlcogolMarket.Manager;
using newAlcogolMarket.Models;
using newAlcogolMarket.Models.Entity;

namespace newAlcogolMarket.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly IAbsentManager _manager;
        public CategoriesController(IAbsentManager manager)
        {
            _manager = manager;
        }
        [HttpGet]
        [Route("categories")]
        public async Task<IList<CategoryofAlcogol>> GetAll()=>await _manager.GetAll();
        [HttpPut]
        [Route("categories")]
        public Task Create([FromBody] CreateCategoryRequest request) => _manager.Create(request.Name);
    }
}